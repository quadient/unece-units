using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using UneceGenerator.Dtos;
using UneceUnits;

namespace UneceGenerator;

public static partial class Generator
{
    private const string ClassNameAllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    private static readonly HashSet<State> ExcludedStates = new()
    {
        State.MarkedAsDeleted,
    };

    private static readonly HashSet<State> ObsoleteStates = new(ExcludedStates)
    {
        State.Deprecated,
    };

    private static readonly HashSet<string> RestrictedClassNames = new()
    {
        nameof(Unit),
        nameof(ConvertibleUnit),
        nameof(UnitValue),
        nameof(IUnit),
        nameof(IConvertibleUnit),
    };

    public static async Task Run(FileInfo fileInfo, DirectoryInfo? outputDirectory = null,
        bool deleteFolderContent = false)
    {
        var serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        AddCustomConverters(serializerOptions);

        var units =
            (await JsonSerializer.DeserializeAsync<UnitDto[]>(fileInfo.OpenRead(), serializerOptions) ??
             throw new InvalidOperationException($"Failed to deserialize JSON on {fileInfo.FullName}."))
            .Where(o => !ExcludedStates.Contains(o.State))
            .GroupBy(CreatePropertyName)
            .SelectMany(g => g.Select(unit => new UnitContext(unit, g.Count() > 1)))
            .ToList();

        var targetDirectory = GetTargetDirectory(outputDirectory, deleteFolderContent);

        await GenerateUnitsClassWithMethods(units, targetDirectory);
        await CreateUnitsClasses(units, targetDirectory);
    }

    private static void AddCustomConverters(JsonSerializerOptions serializerOptions)
    {
        serializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseUpper));
    }

    private static async Task CreateUnitsClasses(List<UnitContext> units,
        DirectoryInfo targetDirectory)
    {
        var convertible = new List<UnitContext>();
        var nonConvertible = new List<UnitContext>();

        foreach (var unitContext in units)
        {
            var unit = unitContext.Unit;
            
            if (unit.IsConvertible)
            {
                convertible.Add(unitContext);
            }
            else
            {
                nonConvertible.Add(unitContext);
            }
        }

        await CreateUnits(targetDirectory, nonConvertible, "Units");
        await CreateUnits(targetDirectory, convertible, "Units.Convertible");
    }

    private static async Task CreateUnits(DirectoryInfo targetDirectory, List<UnitContext> units, string fileName)
    {
        var builder = new StringBuilder();

        AppendNamespace(builder);
        AppendUsing(builder);

        AppendUnitsClassStart(builder);

        foreach (var unitContext in units)
        {
            AppendUnitStaticInstance(unitContext, builder);
        }

        AppendClassEnd(builder);

        await WriteFileAsync(targetDirectory, fileName, builder);
    }

    private static void AppendClassEnd(StringBuilder builder)
    {
        builder.Append('}');
    }

    private static void AppendUnitsClassStart(StringBuilder builder)
    {
        // language=C#
        builder.Append($$"""
                         public static partial class Units {
                         """);
    }

    private static async Task GenerateUnitsClassWithMethods(List<UnitContext> units,
        DirectoryInfo targetDirectory)
    {
        var builder = new StringBuilder();

        AppendNamespace(builder);
        AppendUsing(builder);

        AppendUnitsClassStart(builder);
        AppendTryGetByCommonCode(units, builder);
        AppendClassEnd(builder);

        await WriteFileAsync(targetDirectory, $"Units.Methods", builder);
    }

    private static void AppendTryGetByCommonCode(List<UnitContext> units,
        StringBuilder builder)
    {
        // language=C#
        builder.Append($$"""
                         public static bool TryGetByCommonCode(string commonCode, [NotNullWhen(returnValue: true)] out IUnit? unit)
                         {
                             unit = commonCode switch
                             {
                         """);

        foreach (var (unit, hasConflicts) in units)
        {
            // language=C#
            builder.Append(
                $"\"{SanitizeForClassName(unit.CommonCode)}\" => {(hasConflicts ? CreatePropertyNameWithConflict(unit) : CreatePropertyName(unit))},");
        }

        // language=C#
        builder.Append($$"""
                           _ => null,
                         };
                               
                         return unit != null;
                         }
                         """);
    }

    private static async Task WriteFileAsync(DirectoryInfo targetDirectory, string fileName, StringBuilder builder)
    {
        await using var targetFile = File.Create($"{targetDirectory.FullName}/{fileName}.g.cs");
        await targetFile.WriteAsync(Encoding.UTF8.GetBytes(ParseAndFormat(builder.ToString())));
    }

    private static void AppendUnitStaticInstance(UnitContext unitContext, StringBuilder builder)
    {
        var unit = unitContext.Unit;
        // language=C#
        builder.Append($$"""
                         {{CreateDescription(unit.Description)}}
                         {{(ObsoleteStates.Contains(unit.State) ? $"[Obsolete(\"{unit.State}\")]" : null)}}
                         public static {{GetUnitInterface(unit)}} {{$"{(unitContext.HasConflicts ? CreatePropertyNameWithConflict(unit) : CreatePropertyName(unit))}"}} { get; } = new {{GetUnitClass(unit)}}() {
                             {{nameof(IUnit.Name)}} = "{{Sanitize(unit.Name)}}",
                             {{nameof(IUnit.Symbol)}} = {{GetNullableStringPropertyValue(unit.Symbol)}},
                             {{nameof(IUnit.CommonCode)}} = "{{Sanitize(unit.CommonCode)}}",
                             {{(unit.IsConvertible ? GetConvertibleProperties(unit) : null)}}
                         };
                         """);
    }

    private static string? CreateDescription(string? unitDescription)
    {
        return string.IsNullOrWhiteSpace(unitDescription)
            ? null
            : $"""
               /// <summary>
               /// {unitDescription.Replace("\n", string.Empty)}
               /// </summary>
               """;
    }

    private static string GetUnitInterface(UnitDto unit)
    {
        return unit.IsConvertible ? nameof(IConvertibleUnit) : nameof(IUnit);
    }

    private static string GetUnitClass(UnitDto unit)
    {
        return unit.IsConvertible ? nameof(ConvertibleUnit) : nameof(Unit);
    }

    private static string? GetNullableStringPropertyValue(string? text)
    {
        return string.IsNullOrEmpty(text) ? "null" : $"\"{Sanitize(text)}\"";
    }

    private static DirectoryInfo GetTargetDirectory(DirectoryInfo? directoryInfo, bool deleteFolderContent)
    {
        var targetDirectory = directoryInfo ?? new DirectoryInfo("out");


        if (deleteFolderContent && targetDirectory.Exists)
        {
            targetDirectory.Delete(true);
        }

        if (!targetDirectory.Exists)
        {
            targetDirectory.Create();
        }

        return targetDirectory;
    }

    private static void AppendNamespace(StringBuilder builder)
    {
        // language=C#
        builder.Append($"""
                        // Auto-generated code
                        #nullable enable

                        namespace UneceUnits;

                        """);
    }

    private static string? Sanitize(string? value)
    {
        if (value is null)
        {
            return null;
        }

        WhitespaceRegex().Replace(value, " ");

        return value.Replace("\"", "\\\"");
    }

    private static void AppendUsing(StringBuilder builder)
    {
        // language=C#
        builder.Append($"""
                        using System.Diagnostics.CodeAnalysis;
                        using UneceUnits;

                        """);
    }


    private static string GetConvertibleProperties(UnitDto unit)
    {
        // language=C#
        return $"""
                ConversionGroup = "{unit.ConversionFactor!.ParsedSymbol}",
                ConversionFactor = {unit.ConversionFactor.Factor.ToString(CultureInfo.InvariantCulture)}m,
                """;
    }

    private static string CreatePropertyName(UnitDto unit)
    {
        var unitName = unit.Name;

        if (!char.IsLetter(unitName[0]))
        {
            unitName = $"Unit{unitName}";
        }

        unitName = unitName.Replace("/", " Per ");

        var titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unitName);
        var className = SanitizeForClassName(titleCase);

        while (RestrictedClassNames.Contains(className))
        {
            className += "Unece";
        }

        return className;
    }

    private static string CreatePropertyNameWithConflict(UnitDto unit) =>
        $"{CreatePropertyName(unit)}{SanitizeForClassName(unit.CommonCode)}";

    private static string SanitizeForClassName(string? input) =>
        input == null
            ? string.Empty
            : string.Concat(input.Where(c => !char.IsWhiteSpace(c) && ClassNameAllowedChars.Contains(c)));

    static string ParseAndFormat(string code) =>
        CSharpSyntaxTree.ParseText(SourceText.From(code, Encoding.UTF8)).GetRoot().NormalizeWhitespace().SyntaxTree
            .ToString();

    [GeneratedRegex(@"\s+")]
    private static partial Regex WhitespaceRegex();

    private record UnitContext(UnitDto Unit, bool HasConflicts);
}
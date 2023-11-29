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

    private static readonly HashSet<State> ObsoleteStates = new()
    {
        State.Deprecated, State.MarkedAsDeleted,
    };


    private static readonly HashSet<State> ExcludedStates = new()
    {
        State.MarkedAsDeleted,
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

        var unitsByPropertyName =
            (await JsonSerializer.DeserializeAsync<UnitDto[]>(fileInfo.OpenRead(), serializerOptions) ??
             throw new InvalidOperationException($"Failed to deserialize JSON on {fileInfo.FullName}."))
            .Where(o => !ExcludedStates.Contains(o.State))
            .GroupBy(o => CreatePropertyName(o)).ToList();

        var targetDirectory = GetTargetDirectory(outputDirectory, deleteFolderContent);

        await GenerateUnitsClassWithMethods(unitsByPropertyName, targetDirectory);
        await CreateUnitsClasses(unitsByPropertyName, targetDirectory);
    }

    private static void AddCustomConverters(JsonSerializerOptions serializerOptions)
    {
        serializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseUpper));
    }

    private static async Task CreateUnitsClasses(List<IGrouping<string, UnitDto>> unitsByPropertyName,
        DirectoryInfo targetDirectory)
    {
        var convertible = new List<UnitContext>();
        var nonConvertible = new List<UnitContext>();

        foreach (var unitGroup in unitsByPropertyName)
        {
            foreach (var unit in unitGroup)
            {
                if (unit.IsConvertible)
                {
                    convertible.Add(new UnitContext(unit, unitGroup.Count() > 1));
                }
                else
                {
                    nonConvertible.Add(new UnitContext(unit, unitGroup.Count() > 1));
                }
            }
        }

        await CreateUnits(targetDirectory, nonConvertible);
        await CreateUnits(targetDirectory, convertible, "Convertible");
    }

    private static async Task CreateUnits(DirectoryInfo targetDirectory, List<UnitContext> units,
        string? fileSuffix = null)
    {
        var builder = new StringBuilder();

        AppendNamespace(builder);
        AppendUsing(builder);

        AppendUnitsClassStart(builder);

        foreach (var unitToGenerate in units)
        {
            AppendUnitStaticInstance(unitToGenerate.Unit, builder, unitToGenerate.HasConflicts);
        }

        AppendClassEnd(builder);

        await WriteFileAsync(targetDirectory, $"Units{(fileSuffix is null ? null : $".{fileSuffix}")}", builder);
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

    private static async Task GenerateUnitsClassWithMethods(List<IGrouping<string, UnitDto>> units,
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

    private static void AppendTryGetByCommonCode(List<IGrouping<string, UnitDto>> unitsByPropertyName,
        StringBuilder builder)
    {
        // language=C#
        builder.Append($$"""
                         public static bool TryGetByCommonCode(string commonCode, [NotNullWhen(returnValue: true)] out IUnit? unit)
                         {
                             unit = commonCode switch
                             {
                         """);
        foreach (var unitsGroup in unitsByPropertyName)
        {
            var unitsInGroup = unitsGroup.ToList();
            var hasNamingConflicts = unitsInGroup.Count > 1;

            foreach (var unit in unitsInGroup)
            {
                builder.Append(
                    $"\"{SanitizeForClassName(unit.CommonCode)}\" => {CreatePropertyName(unit, hasNamingConflicts)},");
            }
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

    private static void AppendUnitStaticInstance(UnitDto unit, StringBuilder builder, bool hasConflicts)
    {
        // language=C#
        builder.Append($$"""
                         {{CreateDescription(unit.Description)}}
                         {{(ObsoleteStates.Contains(unit.State) ? $"[Obsolete(\"{unit.State}\")]" : null)}}
                         public static {{GetUnitInterface(unit)}} {{$"{CreatePropertyName(unit, hasConflicts)}"}} { get; } = new {{GetUnitClass(unit)}}() {
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

    private static string CreatePropertyName(UnitDto unit, bool hasConflicts = false)
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

        return hasConflicts ? $"{className}{SanitizeForClassName(unit.CommonCode)}" : className;
    }

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
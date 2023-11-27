using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using UneceGenerator.Dtos;
using UneceUnits;

namespace UneceGenerator;

public static class Generator
{
    private const string ClassNameAllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    private static readonly HashSet<State> ExcludedStates = new()
    {
        State.Deprecated, State.MarkedAsDeleted,
    };

    private static readonly HashSet<string> RestrictedClassNames = new()
    {
        "Unit",
        "ConvertibleUnit",
        "UnitValue",
    };

    public static async Task Run(FileInfo fileInfo, DirectoryInfo? outputDirectory = null,
        bool deleteFolderContent = false)
    {
        var serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = {new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseUpper)},
        };

        var units = (await JsonSerializer.DeserializeAsync<UnitDto[]>(fileInfo.OpenRead(), serializerOptions) ??
                     throw new InvalidOperationException($"Failed to deserialize JSON on {fileInfo.FullName}."))
            .Where(o => !ExcludedStates.Contains(o.State))
            .ToArray();

        var targetDirectory = GetTargetDirectory(outputDirectory, deleteFolderContent);

        await CreateUnitsClass(units, targetDirectory);
    }

    private static async Task CreateUnitsClass(UnitDto[] units, DirectoryInfo targetDirectory)
    {
        var builder = new StringBuilder();
        var unitsByPropertyName = units.GroupBy(o => CreatePropertyName(o)).ToList();

        AppendNamespace(builder);
        AppendUsing(builder);

        // language=C#
        builder.Append($$"""
                         public static class Units {
                         """);
        AppendGetByCommonCode(unitsByPropertyName, builder);
        AppendTryGetConvertibleByCommonCode(unitsByPropertyName, builder);
        AppendTryGetByCommonCode(unitsByPropertyName, builder);
        AppendUnits(unitsByPropertyName, builder);
        builder.Append('}');

        await WriteFileAsync(targetDirectory, $"Units", builder);
    }

    private static void AppendTryGetConvertibleByCommonCode(List<IGrouping<string, UnitDto>> unitsByPropertyName,
        StringBuilder builder)
    {
        // language=C#
        builder.Append($$"""
                         public static bool TryGetConvertibleByCommonCode(string commonCode, [NotNullWhen(returnValue: true)] out IConvertibleUnit? convertibleUnit)
                         {
                            if (TryGetByCommonCode(commonCode, out var unit)) {
                                if (unit is IConvertibleUnit typedUnit) {
                                    convertibleUnit = typedUnit;
                                    return true;
                                }
                            }
                            convertibleUnit = null;
                            
                            return false;
                         }
                         """);
    }

    private static void AppendGetByCommonCode(List<IGrouping<string, UnitDto>> unitsByPropertyName,
        StringBuilder builder)
    {
        // language=C#
        builder.Append($$"""
                         public static IUnit GetByCommonCode(string commonCode)
                         {
                            if (!TryGetByCommonCode(commonCode, out var unit)) {
                                throw new ArgumentException($"Unit with common code '{commonCode}' does not exist.", nameof(commonCode));
                            }
                             return unit;
                         }
                         """);
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
                    $"\"{SanitizeInput(unit.CommonCode)}\" => {CreatePropertyName(unit, hasNamingConflicts)},");
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
        await using var targetFile = File.OpenWrite($"{targetDirectory.FullName}/{fileName}.g.cs");
        await targetFile.WriteAsync(Encoding.UTF8.GetBytes(ParseAndFormat(builder.ToString())));
    }

    private static void AppendUnits(List<IGrouping<string, UnitDto>> unitsByPropertyName, StringBuilder builder)
    {
        builder.AppendLine("#region Units");

        foreach (var unitsGroup in unitsByPropertyName)
        {
            var unitsInGroup = unitsGroup.ToList();

            foreach (var unit in unitsInGroup)
            {
                AppendUnitStaticInstance(unit, builder, unitsInGroup.Count > 1);
            }
        }

        builder.AppendLine("#endregion");
    }

    private static void AppendUnitStaticInstance(UnitDto unit, StringBuilder builder, bool hasConflicts)
    {
        // language=C#
        builder.Append($$"""
                         {{CreateDescription(unit.Description)}}
                         public static {{GetUnitInterface(unit)}} {{$"{CreatePropertyName(unit, hasConflicts)}"}} = new {{GetUnitClass(unit)}}() {
                             {{nameof(Unit.Name)}} = "{{Escape(unit.Name)}}",
                             {{nameof(Unit.Symbol)}} = {{GetNullableStringPropertyValue(unit.Symbol)}},
                             {{nameof(Unit.CommonCode)}} = "{{Escape(unit.CommonCode)}}",
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
        return string.IsNullOrEmpty(text) ? "null" : $"\"{Escape(text)}\"";
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

    private static string? Escape(string? value)
    {
        return value?.Replace("\"", "\\\"");
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
        var className = SanitizeInput(titleCase);

        while (RestrictedClassNames.Contains(className))
        {
            className += "Unece";
        }

        return hasConflicts ? $"{className}{SanitizeInput(unit.CommonCode)}" : className;
    }

    private static string SanitizeInput(string? input) =>
        input == null
            ? string.Empty
            : string.Concat(input.Where(c => !char.IsWhiteSpace(c) && ClassNameAllowedChars.Contains(c)));

    static string ParseAndFormat(string code) =>
        CSharpSyntaxTree.ParseText(SourceText.From(code, Encoding.UTF8)).GetRoot().NormalizeWhitespace().SyntaxTree
            .ToString();
}
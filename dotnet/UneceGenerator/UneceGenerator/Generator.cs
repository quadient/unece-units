using System.Globalization;
using System.Text;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using UneceGenerator.Dtos;
using UneceUnits;

namespace UneceGenerator;

public static class Generator
{
    private const string ClassNameAllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    private static readonly HashSet<string> RestrictedClassNames = new()
    {
        "Unit",
        "ConvertibleUnit",
        "UnitValue",
    };


    public static async Task Run(FileInfo fileInfo, DirectoryInfo? outputDirectory = null,
        bool deleteFolderContent = false)
    {
        var units = await JsonSerializer.DeserializeAsync<UnitDto[]>(fileInfo.OpenRead(), new JsonSerializerOptions()
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    }) ??
                    throw new InvalidOperationException($"Failed to deserialize JSON on {fileInfo.FullName}.");


        var targetDirectory = GetTargetDirectory(outputDirectory, deleteFolderContent);

        foreach (var unitJson in units)
        {
            var builder = new StringBuilder();
            var className = CreateClassName(unitJson.Name);

            AppendNamespace(builder);
            AppendUsings(builder);
            AppendClass(className, unitJson, builder);

            await using var targetFile = File.OpenWrite($"{targetDirectory.FullName}/{className}.Generated.cs");
            await targetFile.WriteAsync(Encoding.UTF8.GetBytes(ParseAndFormat(builder.ToString())));
        }
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
        builder.Append($"""
                        // Auto-generated code
                        #nullable enable

                        namespace UneceUnits.Generated;

                        """);
    }

    private static void AppendUsings(StringBuilder builder)
    {
        builder.Append($"""
                        using UneceUnits;

                        """);
    }

    private static void AppendClass(string className, UnitDto unit, StringBuilder builder)
    {
        var baseClass = unit.IsConvertible ? nameof(ConvertibleUnit) : nameof(Unit);
        builder.Append($$"""
                         public class {{className}} : {{baseClass}} {
                             public {{className}}() {
                                 CommonCode = "{{unit.CommonCode}}";
                                 Name = "{{unit.Name}}";
                                 Symbol = "{{unit.Symbol?.Replace("\"", "\\\"")}}";
                                 {{(unit.IsConvertible ? GetConvertibleProperties(unit) : string.Empty)}}
                             }
                         }
                         """);
    }

    private static string GetConvertibleProperties(UnitDto unit)
    {
        return $"""
                ConversionGroup = "{unit.ConversionFactor!.ParsedSymbol}";
                ConversionFactor = {unit.ConversionFactor.Factor.ToString(CultureInfo.InvariantCulture)}m;
                """;
    }

    private static string CreateClassName(string unitName)
    {
        if (!char.IsLetter(unitName[0]))
        {
            unitName = $"Unit{unitName}";
        }

        unitName = unitName.Replace("/", " per ");

        var titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unitName);
        var className = string.Concat(titleCase.Where(c => !char.IsWhiteSpace(c) && ClassNameAllowedChars.Contains(c)));

        while (RestrictedClassNames.Contains(className))
        {
            className += "Unece";
        }

        return className;
    }

    static string ParseAndFormat(string code) =>
        CSharpSyntaxTree.ParseText(SourceText.From(code, Encoding.UTF8)).GetRoot().NormalizeWhitespace().SyntaxTree
            .ToString();
}
using System.Globalization;
using System.Text;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using UneceGenerator.Dtos;
using UneceGenerator.Units;

namespace UneceGenerator;

public class Generator
{
    const string _allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public static async Task Run(FileInfo fileInfo)
    {
        var units = await JsonSerializer.DeserializeAsync<UnitDto[]>(fileInfo.OpenRead(), new JsonSerializerOptions()
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    }) ??
                    throw new InvalidOperationException($"Failed to deserialize JSON on {fileInfo.FullName}.");


        var outputPath = "out";

        if (Directory.Exists(outputPath))
        {
            Directory.Delete(outputPath, true);
        }

        Directory.CreateDirectory(outputPath);

        foreach (var unitJson in units)
        {
            var builder = new StringBuilder();
            var className = CreateClassName(unitJson.Name);

            AppendNamespace(builder);
            AppendClass(className, unitJson, builder);

            await using var targetFile = File.OpenWrite($"out/{className}.cs");
            await targetFile.WriteAsync(Encoding.UTF8.GetBytes(ParseAndFormat(builder.ToString())));
        }
    }

    private static void AppendNamespace(StringBuilder builder)
    {
        builder.Append($"""
                        namespace UneceGenerator.Units;

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
        // if unit name starts with other symbol than letter, prepend "Unit"
        if (!char.IsLetter(unitName[0]))
        {
            unitName = $"Unit{unitName}";
        }
        
        unitName = unitName.Replace("/", " per ");

        var titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unitName);
        return string.Concat(titleCase.Where(c => !char.IsWhiteSpace(c) && _allowedChars.Contains(c)));
    }
    
    static string ParseAndFormat(string code) =>
        CSharpSyntaxTree.ParseText(SourceText.From(code, Encoding.UTF8)).GetRoot().NormalizeWhitespace().SyntaxTree.ToString();
}
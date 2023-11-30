namespace UneceGenerator.Dtos;

public class ConversionFactorDto
{
    public required decimal Factor { get; set; }
    public string? ParsedSymbol { get; set; }
    public HashSet<string>? CommonCodeReferences { get; set; }
}
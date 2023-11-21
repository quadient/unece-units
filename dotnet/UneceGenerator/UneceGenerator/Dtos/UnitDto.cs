namespace UneceGenerator.Dtos;

public class UnitDto
{
    public required State State { get; set; }
    public required string CommonCode { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Symbol { get; set; }
    public ConversionFactorDto? ConversionFactor { get; set; }
    public string? ParsedSymbol { get; set; }
    public required string Categories { get; set; }

    public bool IsConvertible => ConversionFactor != null && !string.IsNullOrEmpty(ConversionFactor.ParsedSymbol);
}
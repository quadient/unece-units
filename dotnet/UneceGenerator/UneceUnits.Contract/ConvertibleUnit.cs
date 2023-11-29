namespace UneceUnits;

public interface IConvertibleUnit : IUnit
{
    /// <summary>
    /// For example "meter" for "kilometer", "centimeter", ...
    /// </summary>
    public string ConversionGroup { get; }

    /// <summary>
    /// For example 1000 for "kilometer", 0.01 for "centimeter", ...
    /// </summary>
    public decimal ConversionFactor { get; }
}

public record ConvertibleUnit : IConvertibleUnit
{
    public required string Name { get; init; }

    public required string CommonCode { get; init; }

    public required string? Symbol { get; init; }

    public required string ConversionGroup { get; init; }
    public required decimal ConversionFactor { get; init; }
}
namespace UneceUnits;

public interface IUnit
{
    /// <summary>
    /// For example kilogram, meter, liter.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Unique identifier defined by UNECE standard, for example KGM, MTR, LTR.
    /// </summary>
    public string CommonCode { get; }

    /// <summary>
    /// Case sensitive defined by standard, for example kg, m, l.
    /// </summary>
    public string? Symbol { get; }
}

public interface IConvertibleUnit : IUnit
{
    public string ConversionGroup { get; }
    public decimal ConversionFactor { get; }
}

public record Unit : IUnit
{
    public required string Name { get; init; }
    public required string CommonCode { get; init; }
    public required string? Symbol { get; init; }
}

public record ConvertibleUnit : IConvertibleUnit
{
    public required string Name { get; init; }

    public required string CommonCode { get; init; }

    public required string? Symbol { get; init; }

    public required string ConversionGroup { get; init; }
    public required decimal ConversionFactor { get; init; }
}
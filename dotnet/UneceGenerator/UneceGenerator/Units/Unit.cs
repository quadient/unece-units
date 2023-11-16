namespace UneceGenerator.Units;

public interface IUnit
{
    public string Name { get; }
    public string CommonCode { get; }
    public string? Symbol { get; }
}

public interface IConvertibleUnit : IUnit
{
    public string ConversionGroup { get; }
    public decimal ConversionFactor { get; }
}

public class Unit : IUnit
{
    /// <summary>
    /// For example kilogram, meter, liter.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Unique identifier defined by UNECE standard, for example KGM, MTR, LTR.
    /// </summary>
    public required string CommonCode { get; init; }


    /// <summary>
    /// Case sensitive defined by standard, for example kg, m, l.
    /// </summary>
    public string? Symbol { get; init; }
}

public class ConvertibleUnit : IConvertibleUnit
{
    /// <summary>
    /// For example kilogram, meter, liter.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Unique identifier defined by UNECE standard, for example KGM, MTR, LTR.
    /// </summary>
    public required string CommonCode { get; init; }

    /// <summary>
    /// Case sensitive defined by standard, for example kg, m, l.
    /// </summary>
    public required string? Symbol { get; init; }

    public required string ConversionGroup { get; init; }
    public required decimal ConversionFactor { get; init; }
}
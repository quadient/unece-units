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

public record Unit : IUnit
{
    public required string Name { get; init; }
    public required string CommonCode { get; init; }
    public required string? Symbol { get; init; }
}
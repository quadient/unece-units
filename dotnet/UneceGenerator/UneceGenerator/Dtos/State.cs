namespace UneceGenerator.Dtos;

public enum State
{
    /// <summary>
    /// Default state
    /// </summary>
    Active = 0,

    /// <summary>
    /// Added. New unit added in this release of the code list
    /// </summary>
    Added = 1,

    /// <summary>
    /// Changed name. Changes to the unit name in this release of the code list
    /// </summary>
    ChangedName = 2,

    /// <summary>
    /// Changed characteristic(s). Changes other than to the unit name in this release of the code list, e.g. a change
    /// to the level/category
    /// </summary>
    ChangedCharacteristics = 3,

    /// <summary>
    /// Deprecated. Units not recommended for use by the Bureau
    /// </summary>
    Deprecated = 4,

    /// <summary>
    /// Marked as deleted. Units marked as deleted will be retained indefinitely in the code lists. When appropriate,
    /// these units may subsequently be reinstated via the maintenance process
    /// </summary>
    MarkedAsDeleted = 5,

    /// <summary>
    /// Reinstated. Units previously marked as deleted and reinstated
    /// </summary>
    Reinstated = 6,
}
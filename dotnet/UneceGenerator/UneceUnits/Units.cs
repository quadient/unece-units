using System.Diagnostics.CodeAnalysis;

namespace UneceUnits;

public static partial class Units
{
    public static IUnit GetByCommonCode(string commonCode)
    {
        if (!TryGetByCommonCode(commonCode, out var unit))
        {
            throw new ArgumentOutOfRangeException(nameof(commonCode),
                $"Unit with common code '{commonCode}' does not exist.");
        }

        return unit;
    }

    public static IConvertibleUnit GetConvertibleByCommonCode(string commonCode)
    {
        if (!TryGetConvertibleByCommonCode(commonCode, out var unit))
        {
            throw new ArgumentOutOfRangeException(nameof(commonCode),
                $"Unit with common code '{commonCode}' does not exist or is not convertible.");
        }

        return unit;
    }

    public static bool TryGetConvertibleByCommonCode(string commonCode,
        [NotNullWhen(returnValue: true)] out IConvertibleUnit? convertibleUnit)
    {
        if (TryGetByCommonCode(commonCode, out var unit))
        {
            if (unit is IConvertibleUnit typedUnit)
            {
                convertibleUnit = typedUnit;
                return true;
            }
        }

        convertibleUnit = null;
        return false;
    }
}
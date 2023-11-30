using System.Diagnostics.CodeAnalysis;

namespace UneceUnits;

public record UnitValue
{
    public required decimal Value { get; init; }

    public required IUnit Unit { get; init; }

    public bool IsConvertible => Unit is IConvertibleUnit;

    public UnitValue Convert(IConvertibleUnit targetUnit)
    {
        var convertibleUnit = GetConvertibleUnit();

        AssertSameConversionGroup(convertibleUnit, targetUnit);

        return new UnitValue
        {
            Value = Value * convertibleUnit.ConversionFactor / targetUnit.ConversionFactor,
            Unit = targetUnit,
        };
    }

    public static UnitValue operator +(UnitValue a, UnitValue b)
    {
        if (!a.IsConvertible && !b.IsConvertible)
        {
            AssertSameUnit(a.Unit, b.Unit);
            return a with {Value = a.Value + b.Value};
        }

        var convertibleA = a.GetConvertibleUnit();
        var convertedB = b.Convert(convertibleA);

        return a with {Value = a.Value + convertedB.Value};
    }

    public static UnitValue operator -(UnitValue a, UnitValue b)
    {
        if (!a.IsConvertible && !b.IsConvertible)
        {
            AssertSameUnit(a.Unit, b.Unit);
            return a with {Value = a.Value - b.Value};
        }

        var convertibleA = a.GetConvertibleUnit();
        var convertedB = b.Convert(convertibleA);

        return a with {Value = a.Value - convertedB.Value};
    }

    public static UnitValue operator *(decimal a, UnitValue b) => b * a;

    public static UnitValue operator *(UnitValue a, decimal value) => a with {Value = a.Value * value};

    public static UnitValue operator /(UnitValue a, decimal value) => a with {Value = a.Value / value};

    public static bool operator <(UnitValue a, UnitValue b)
    {
        if (!a.IsConvertible && !b.IsConvertible)
        {
            AssertSameUnit(a.Unit, b.Unit);
            return a.Value < b.Value;
        }

        var convertibleA = a.GetConvertibleUnit();
        var convertedB = b.Convert(convertibleA);

        return a.Value < convertedB.Value;
    }

    public static bool operator >(UnitValue a, UnitValue b)
    {
        if (!a.IsConvertible && !b.IsConvertible)
        {
            AssertSameUnit(a.Unit, b.Unit);
            return a.Value > b.Value;
        }

        var convertibleA = a.GetConvertibleUnit();
        var convertedB = b.Convert(convertibleA);

        return a.Value > convertedB.Value;
    }

    public static bool operator <=(UnitValue a, UnitValue b) => a < b || a == b;

    public static bool operator >=(UnitValue a, UnitValue b) => a > b || a == b;

    bool TryGetConvertibleUnit([NotNullWhen(returnValue: true)] out IConvertibleUnit? convertibleUnit)
    {
        if (Unit is IConvertibleUnit unit)
        {
            convertibleUnit = unit;
            return true;
        }

        convertibleUnit = null;
        return false;
    }

    IConvertibleUnit GetConvertibleUnit()
    {
        if (!TryGetConvertibleUnit(out var unit))
        {
            throw new ConversionException(
                $"Unit '{Unit.Name} ({Unit.CommonCode})' is not convertible.");
        }

        return unit;
    }

    private static void AssertSameUnit(IUnit sourceUnit, IUnit targetUnit)
    {
        if (sourceUnit != targetUnit)
        {
            throw new ConversionException(
                $"Source unit '{sourceUnit}' does not equal to target unit '{targetUnit}'.");
        }
    }

    private static void AssertSameConversionGroup(IConvertibleUnit sourceUnit, IConvertibleUnit targetUnit)
    {
        if (!Equals(sourceUnit.ConversionGroup, targetUnit.ConversionGroup))
        {
            throw new ConversionException(
                $"Conversion group '{sourceUnit.ConversionGroup}' does not equal to target conversion group '{targetUnit.ConversionGroup}'.");
        }
    }
}
using System.Diagnostics.CodeAnalysis;

namespace UneceUnits;

public record UnitValue
{
    // TODO[j.semerak]: Precision?
    public required decimal Value { get; init; }

    public required IUnit Unit { get; init; }

    public bool IsConvertible => Unit is IConvertibleUnit;

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
            throw new InvalidOperationException(
                $"Unit '{Unit.Name} ({Unit.CommonCode})' is not convertible.");
        }

        return unit;
    }

    private static void AssertSameUnit(IUnit sourceUnit, IUnit targetUnit)
    {
        if (sourceUnit != targetUnit)
        {
            throw new InvalidOperationException(
                $"Source unit '{sourceUnit}' does not equal to target unit '{targetUnit}'.");
        }
    }

    private static void AssertSameConversionGroup(IConvertibleUnit sourceUnit, IConvertibleUnit targetUnit)
    {
        if (!Equals(sourceUnit.ConversionGroup, targetUnit.ConversionGroup))
        {
            throw new InvalidOperationException(
                $"Conversion group '{sourceUnit.ConversionGroup}' does not equal to target conversion group '{targetUnit.ConversionGroup}'.");
        }
    }

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
        var convertibleB = b.GetConvertibleUnit();

        AssertSameConversionGroup(convertibleA, convertibleB);

        return new UnitValue
        {
            Value = a.Value + b.Value * convertibleB.ConversionFactor / convertibleA.ConversionFactor,
            Unit = convertibleA,
        };
    }

    public static UnitValue operator -(UnitValue a, UnitValue b)
    {
        if (!a.IsConvertible && !b.IsConvertible)
        {
            AssertSameUnit(a.Unit, b.Unit);
            return a with {Value = a.Value - b.Value};
        }

        var convertibleA = a.GetConvertibleUnit();
        var convertibleB = b.GetConvertibleUnit();

        AssertSameConversionGroup(convertibleA, convertibleB);

        return new UnitValue
        {
            Value = a.Value - b.Value * convertibleB.ConversionFactor / convertibleA.ConversionFactor,
            Unit = convertibleA,
        };
    }

    public static UnitValue operator *(decimal a, UnitValue b)
    {
        return b with {Value = a * b.Value};
    }

    public static UnitValue operator *(UnitValue a, decimal value)
    {
        return a with {Value = a.Value * value};
    }

    public static UnitValue operator /(UnitValue a, UnitValue b)
    {
        if (!a.IsConvertible && !b.IsConvertible)
        {
            AssertSameUnit(a.Unit, b.Unit);
            return a with {Value = a.Value / b.Value};
        }

        var convertibleA = a.GetConvertibleUnit();
        var convertibleB = b.GetConvertibleUnit();

        AssertSameConversionGroup(convertibleA, convertibleB);

        return a with {Value = a.Value / (b.Value * convertibleB.ConversionFactor / convertibleA.ConversionFactor)};
    }

    public static bool operator <(UnitValue a, UnitValue b)
    {
        if (!a.IsConvertible && !b.IsConvertible)
        {
            AssertSameUnit(a.Unit, b.Unit);
            return a.Value < b.Value;
        }

        var convertibleA = a.GetConvertibleUnit();
        var convertibleB = b.GetConvertibleUnit();

        AssertSameConversionGroup(convertibleA, convertibleB);

        return a.Value < b.Value * convertibleB.ConversionFactor / convertibleA.ConversionFactor;
    }

    public static bool operator >(UnitValue a, UnitValue b)
    {
        if (!a.IsConvertible && !b.IsConvertible)
        {
            AssertSameUnit(a.Unit, b.Unit);
            return a.Value > b.Value;
        }
        
        var convertibleA = a.GetConvertibleUnit();
        var convertibleB = b.GetConvertibleUnit();

        AssertSameConversionGroup(convertibleA, convertibleB);

        return a.Value > b.Value * convertibleB.ConversionFactor / convertibleA.ConversionFactor;
    }

    public static bool operator <=(UnitValue a, UnitValue b) => a < b || a == b;

    public static bool operator >=(UnitValue a, UnitValue b) => a > b || a == b;
}
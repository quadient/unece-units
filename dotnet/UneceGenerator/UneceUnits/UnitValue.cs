using System.Diagnostics.CodeAnalysis;
using UneceUnits.Generated;

namespace UneceUnits;

public class UnitValue
{
    public required decimal Value { get; init; }

    public required IUnit Unit { get; init; }

    public bool IsConvertible => Unit is IConvertibleUnit;

    private bool TryGetConvertible([NotNullWhen(returnValue: true)] out IConvertibleUnit? convertibleUnit)
    {
        if (Unit is IConvertibleUnit unit)
        {
            convertibleUnit = unit;
            return true;
        }

        convertibleUnit = null;
        return false;
    }

    private void AssertSameConversionGroup(IConvertibleUnit target, out IConvertibleUnit convertibleUnit)
    {
        if (!TryGetConvertible(out var unit))
        {
            throw new InvalidOperationException(
                $"Unit '{Unit.Name}' is not convertible.");
        }

        convertibleUnit = unit;

        if (!Equals(unit.ConversionGroup, target.ConversionGroup))
        {
            throw new InvalidOperationException(
                $"Conversion group '{unit.ConversionGroup}' does not equal to target conversion group '{target.ConversionGroup}'.");
        }
    }

    public UnitValue Convert(IConvertibleUnit targetUnit)
    {
        AssertSameConversionGroup(targetUnit, out var convertibleUnit);

        return new UnitValue
        {
            Value = Value * convertibleUnit.ConversionFactor / targetUnit.ConversionFactor,
            Unit = targetUnit,
        };
    }

    // TODO[j.semerak]: Operators.
}
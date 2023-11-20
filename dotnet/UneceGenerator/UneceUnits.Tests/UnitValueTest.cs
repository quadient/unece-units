using FluentAssertions;
using UneceUnits.Generated;

namespace UneceUnits.Tests;

public class UnitValueTest
{
    [Fact]
    public void Convert_GivenSameConversionGroup_DoesConvert()
    {
        var meter = new UnitValue()
        {
            Value = 1.0m,
            Unit = new Metre(),
        };

        var converted = meter.Convert(new MicrometreMicron());
        converted.Value.Should().Be(1000000);
        converted.Unit.Should().Be(new MicrometreMicron());
    }

    // [Fact]
    // public void TryGetConvertible_ReturnsExpectedResults()
    // {
    //     var convertibleUnit = new ConvertibleUnit();
    //     var nonConvertibleUnit = new NonConvertibleUnit();
    //     var unitValueWithConvertible = new UnitValue {Unit = convertibleUnit};
    //     var unitValueWithNonConvertible = new UnitValue {Unit = nonConvertibleUnit};
    //
    //     unitValueWithConvertible.TryGetConvertible(out _).Should().BeTrue();
    //     unitValueWithNonConvertible.TryGetConvertible(out _).Should().BeFalse();
    // }
    //
    // [Fact]
    // public void AssertSameConversionGroup_ThrowsExceptionWhenDifferentGroups()
    // {
    //     var convertibleUnit1 = new ConvertibleUnit {ConversionGroup = "group1"};
    //     var convertibleUnit2 = new ConvertibleUnit {ConversionGroup = "group2"};
    //     var unitValue = new UnitValue {Unit = convertibleUnit1};
    //
    //     Action act = () => unitValue.AssertSameConversionGroup(convertibleUnit2);
    //     act.Should().Throw<InvalidOperationException>();
    // }
    //
    // [Fact]
    // public void Convert_ReturnsExpectedValue()
    // {
    //     var convertibleUnit = new ConvertibleUnit {ConversionFactor = 2};
    //     var targetUnit = new ConvertibleUnit {ConversionFactor = 2, ConversionGroup = "sameGroup"};
    //     var unitValue = new UnitValue {Value = 10, Unit = convertibleUnit};
    //
    //     var result = unitValue.Convert(targetUnit);
    //
    //     result.Value.Should().Be(10);
    //     result.Unit.Should().Be(targetUnit);
    // }
}
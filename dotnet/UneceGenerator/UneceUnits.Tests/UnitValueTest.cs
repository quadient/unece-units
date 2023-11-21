using FluentAssertions;
using UneceUnits.Generated;

namespace UneceUnits.Tests;

public class UnitValueTest
{
    [Fact]
    public void Convert_GivenSameConversionGroup_DoesConvert()
    {
        var meter = new UnitValue
        {
            Value = 1.065m,
            Unit = Units.Metre,
        };

        var converted = meter.Convert(Units.MicrometreMicron);
        converted.Value.Should().Be(1065000);
        converted.Unit.Should().Be(Units.MicrometreMicron);
    }
}
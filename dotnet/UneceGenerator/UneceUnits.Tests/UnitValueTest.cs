using FluentAssertions;

namespace UneceUnits.Tests;

public class UnitValueTest
{
    private const decimal Precision = 1e-3m;

    [Fact]
    public void IsConvertible_GivenConvertibleUnit_ReturnsTrue()
    {
        var unit = new UnitValue {Unit = Units.Metre, Value = 1};
        unit.IsConvertible.Should().BeTrue();
    }

    [Fact]
    public void IsConvertible_GivenNotConvertibleUnit_ReturnsFalse()
    {
        var unit = new UnitValue {Unit = Units.Bag, Value = 1};
        unit.IsConvertible.Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(ConvertData))]
    public void Convert_GivenSameConversionGroup_DoesConvert(UnitValue given, UnitValue expected)
    {
        var result = given.Convert((IConvertibleUnit) expected.Unit);
        result.Unit.Should().Be(expected.Unit);
        result.Value.Should().BeApproximately(expected.Value, Precision);
    }

    [Fact]
    public void Convert_GivenNotConvertibleUnit_DoesThrow()
    {
        var bag = new UnitValue
        {
            Value = 1,
            Unit = Units.Bag,
        };

        Assert.Throws<InvalidOperationException>(() => { _ = bag.Convert(Units.Metre); });
    }

    [Fact]
    public void Convert_GivenOtherConversionGroup_DoesThrow()
    {
        var bag = new UnitValue
        {
            Value = 1,
            Unit = Units.Metre,
        };

        Assert.Throws<InvalidOperationException>(() => { _ = bag.Convert(Units.Litre); });
    }

    [Theory]
    [MemberData(nameof(PlusOperatorData))]
    [MemberData(nameof(ShouldThrowCommonData))]
    public void OperatorAdd_GivenSameConversionGroup_DoesAddProperly(UnitValue a, UnitValue b, UnitValue? expected)
    {
        if (expected == null)
        {
            Assert.Throws<InvalidOperationException>(() => { _ = a + b; });
            return;
        }

        var result = a + b;
        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(MinusOperatorData))]
    [MemberData(nameof(ShouldThrowCommonData))]
    public void OperatorMinus_GivenSameConversionGroup_DoesSubtractProperly(UnitValue a, UnitValue b,
        UnitValue? expected)
    {
        if (expected == null)
        {
            Assert.Throws<InvalidOperationException>(() => { _ = a - b; });
            return;
        }

        var result = a - b;
        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(DivisionOperatorData))]
    [MemberData(nameof(ShouldThrowCommonData))]
    public void OperatorDivision_GivenSameConversionGroup_DoesDivideProperly(UnitValue a, UnitValue b,
        UnitValue? expected)
    {
        if (expected == null)
        {
            if (b.Value == 0.0m)
            {
                Assert.Throws<DivideByZeroException>(() => { _ = a / b; });
            }
            else
            {
                Assert.Throws<InvalidOperationException>(() => { _ = a / b; });
            }

            return;
        }

        var result = a / b;
        result.Unit.Should().Be(expected.Unit);
        result.Value.Should().BeApproximately(expected.Value, Precision);
    }

    [Theory]
    [MemberData(nameof(MultiplicationOperatorData))]
    public void OperatorMultiplication_GivenSameConversionGroup_DoesAddProperly(UnitValue unitValue, decimal multiplier,
        UnitValue expected)
    {
        var result = unitValue * multiplier;
        result.Unit.Should().Be(expected.Unit);
        result.Value.Should().BeApproximately(expected.Value, Precision);

        result = multiplier * unitValue;
        result.Unit.Should().Be(expected.Unit);
        result.Value.Should().BeApproximately(expected.Value, Precision);
    }


    [Theory]
    [InlineData(1, 2, true, false)] // a < b
    [InlineData(1e-13, 1e-12, true, false)] // a < b
    [InlineData(1e-12, 1e-13, false, true)] // a > b
    [InlineData(2, 1, false, true)] // a > b
    [InlineData(1, 1, false, false)] // a == b
    public void OperatorLessAndGreaterThan_GivenSameUnit_DoesCompareProperly(decimal metreAValue,
        decimal metreBValue, bool lessThanExpected, bool greaterThanExpected)
    {
        var metreA = new UnitValue {Value = metreAValue, Unit = Units.Metre};
        var metreB = new UnitValue {Value = metreBValue, Unit = Units.Metre};

        (metreA < metreB).Should().Be(lessThanExpected);
        (metreA > metreB).Should().Be(greaterThanExpected);
    }

    [Theory]
    [InlineData(1, 101, true, false)] // a < b
    [InlineData(1e-13, 1e-10, true, false)] // a < b
    [InlineData(1, 99, false, true)] // a > b
    [InlineData(2, 2, false, true)] // a > b
    [InlineData(1e-14, 1e-12, false, false)] // a == b
    [InlineData(2, 200, false, false)] // a == b
    public void OperatorLessAndGreaterThan_GivenDifferentUnit_DoesCompareProperly(decimal metreValue,
        decimal centimetreValue, bool lessThanExpected, bool greaterThanExpected)
    {
        var metre = new UnitValue {Value = metreValue, Unit = Units.Metre};
        var centimetre = new UnitValue {Value = centimetreValue, Unit = Units.Centimetre};

        (metre < centimetre).Should().Be(lessThanExpected);
        (metre > centimetre).Should().Be(greaterThanExpected);
    }

    [Fact]
    public void OperatorLessAndGreaterThan_GivenDifferentUnit_ThrowsInvalidOperationException()
    {
        var metre = new UnitValue {Value = 1, Unit = Units.Metre};
        var bag = new UnitValue {Value = 1, Unit = Units.Bag};
        var activity = new UnitValue {Value = 1, Unit = Units.Activity};

        Assert.Throws<InvalidOperationException>(() => { _ = metre < bag; });
        Assert.Throws<InvalidOperationException>(() => { _ = bag < metre; });
        Assert.Throws<InvalidOperationException>(() => { _ = bag < activity; });
        Assert.Throws<InvalidOperationException>(() => { _ = activity < bag; });
        Assert.Throws<InvalidOperationException>(() => { _ = metre > bag; });
        Assert.Throws<InvalidOperationException>(() => { _ = bag > metre; });
        Assert.Throws<InvalidOperationException>(() => { _ = bag > activity; });
        Assert.Throws<InvalidOperationException>(() => { _ = activity > bag; });
    }


    [Theory]
    [InlineData(1, 2, true)] // a < b
    [InlineData(2, 1, false)] // a > b
    [InlineData(1e-13, 1e-12, true)] // a < b
    [InlineData(1e-12, 1e-13, false)] // a > b
    [InlineData(1, 1, false)] // a == b
    [InlineData(1, 1.000001, true)]
    [InlineData(1.000001, 1, false)]
    public void OperatorLessAndGreaterOrEqual_GivenNotConvertibleUnits_DoesCompareProperly(decimal bagAValue,
        decimal bagBValue, bool expected)
    {
        var bagA = new UnitValue {Unit = Units.Bag, Value = bagAValue};
        var bagB = new UnitValue {Unit = Units.Bag, Value = bagBValue};

        (bagA < bagB).Should().Be(expected);
        (bagA <= bagB).Should().Be(bagAValue == bagBValue ? !expected : expected);
        (bagA > bagB).Should().Be(bagAValue == bagBValue ? expected : !expected);
        (bagA >= bagB).Should().Be(!expected);
    }

    #region TestData

    public static IEnumerable<object[]> ConvertData =>
        new List<object[]>
        {
            new object[]
            {
                new UnitValue {Value = 1.065m, Unit = Units.Metre},
                new UnitValue {Value = 1065000m, Unit = Units.MicrometreMicron},
            },
            new object[]
            {
                new UnitValue {Value = 1.065m, Unit = Units.Metre},
                new UnitValue {Value = 106.5m, Unit = Units.Centimetre},
            },
            new object[]
            {
                new UnitValue {Value = 1.065m, Unit = Units.Metre},
                new UnitValue {Value = 1.065m, Unit = Units.Metre},
            },
            new object[]
            {
                new UnitValue {Value = 1.065m, Unit = Units.Metre},
                new UnitValue {Value = 0.001065m, Unit = Units.Kilometre},
            },
            new object[]
            {
                new UnitValue {Value = -1.065m, Unit = Units.Litre},
                new UnitValue {Value = -1065m, Unit = Units.Millilitre},
            },
            new object[]
            {
                new UnitValue {Value = -1.065m, Unit = Units.Litre},
                new UnitValue {Value = -0.001065m, Unit = Units.CubicMetre},
            },

            new object[]
            {
                new UnitValue {Value = 0, Unit = Units.GramPerCubicCentimetre},
                new UnitValue {Value = 0, Unit = Units.GramPerCubicCentimetre},
            },
            new object[]
            {
                new UnitValue {Value = 15, Unit = Units.MilePerHourStatuteMile},
                new UnitValue {Value = 6.7056m, Unit = Units.MetrePerSecond},
            },
            new object[]
            {
                new UnitValue {Value = 100, Unit = Units.MilePerHourStatuteMile},
                new UnitValue {Value = 160.9344m, Unit = Units.KilometrePerHour},
            },
        };


    public static IEnumerable<object?[]> ShouldThrowCommonData =>
        new List<UnitValue?[]>
        {
            new UnitValue?[]
            {
                new() {Value = 1m, Unit = Units.Metre},
                new() {Value = 1m, Unit = Units.Bag},
                null,
            },
            new UnitValue?[]
            {
                new() {Value = 1m, Unit = Units.Bag},
                new() {Value = 1m, Unit = Units.Metre},
                null,
            },
            new UnitValue?[]
            {
                new() {Value = 1m, Unit = Units.Bag},
                new() {Value = 1m, Unit = Units.Activity},
                null,
            },
        };

    public static IEnumerable<object?[]> PlusOperatorData =>
        new List<UnitValue?[]>
        {
            new UnitValue?[]
            {
                new() {Value = 1m, Unit = Units.Metre},
                new() {Value = 2m, Unit = Units.Metre},
                new() {Value = 3m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 1e6m, Unit = Units.Metre},
                new() {Value = 2m, Unit = Units.Centimetre},
                new() {Value = 1000000.02m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 2m, Unit = Units.Centimetre},
                new() {Value = 1e6m, Unit = Units.Metre},
                new() {Value = 100000002m, Unit = Units.Centimetre},
            },
            new UnitValue?[]
            {
                new() {Value = 1.065m, Unit = Units.Metre},
                new() {Value = 106.6m, Unit = Units.Centimetre},
                new() {Value = 2.131m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = -106.6m, Unit = Units.Centimetre},
                new() {Value = -1.066m, Unit = Units.Metre},
            },

            // Both operands are zero
            new UnitValue?[]
            {
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = 0m, Unit = Units.Metre}
            },

            // One operand is zero, the other is not
            new UnitValue?[]
            {
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = 1m, Unit = Units.Metre},
                new() {Value = 1m, Unit = Units.Metre}
            },

            // Both values are negative
            new UnitValue?[]
            {
                new() {Value = -1m, Unit = Units.Metre},
                new() {Value = -2m, Unit = Units.Metre},
                new() {Value = -3m, Unit = Units.Metre}
            },

            // Large numbers
            new UnitValue?[]
            {
                new() {Value = 1e6m, Unit = Units.Metre},
                new() {Value = 2e6m, Unit = Units.Metre},
                new() {Value = 3e6m, Unit = Units.Metre}
            },

            // Small numbers
            new UnitValue?[]
            {
                new() {Value = 0.000001m, Unit = Units.Metre},
                new() {Value = 0.000002m, Unit = Units.Metre},
                new() {Value = 0.000003m, Unit = Units.Metre}
            },

            // Not convertible
            new UnitValue?[]
            {
                new() {Value = 1, Unit = Units.Bag},
                new() {Value = 2, Unit = Units.Bag},
                new() {Value = 3, Unit = Units.Bag}
            },
        };

    public static IEnumerable<object?[]> MinusOperatorData =>
        new List<UnitValue?[]>
        {
            new UnitValue?[]
            {
                new() {Value = 1m, Unit = Units.Metre},
                new() {Value = 2m, Unit = Units.Metre},
                new() {Value = -1m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 1e6m, Unit = Units.Metre},
                new() {Value = 2m, Unit = Units.Centimetre},
                new() {Value = 999999.98m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 2m, Unit = Units.Centimetre},
                new() {Value = 1e6m, Unit = Units.Metre},
                new() {Value = -99999998m, Unit = Units.Centimetre},
            },
            new UnitValue?[]
            {
                new() {Value = 1.065m, Unit = Units.Metre},
                new() {Value = 106.6m, Unit = Units.Centimetre},
                new() {Value = -0.001m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = -106.6m, Unit = Units.Centimetre},
                new() {Value = 1.066m, Unit = Units.Metre},
            },

            // Both operands are zero
            new UnitValue?[]
            {
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = 0m, Unit = Units.Metre}
            },

            // One operand is zero, the other is not
            new UnitValue?[]
            {
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = 1m, Unit = Units.Metre},
                new() {Value = -1m, Unit = Units.Metre}
            },

            // Both values are negative
            new UnitValue?[]
            {
                new() {Value = -1m, Unit = Units.Metre},
                new() {Value = -2m, Unit = Units.Metre},
                new() {Value = 1m, Unit = Units.Metre}
            },

            // Large numbers
            new UnitValue?[]
            {
                new() {Value = 1e6m, Unit = Units.Metre},
                new() {Value = 2e6m, Unit = Units.Metre},
                new() {Value = -1e6m, Unit = Units.Metre}
            },

            // Small numbers
            new UnitValue?[]
            {
                new() {Value = 0.000001m, Unit = Units.Metre},
                new() {Value = 0.000002m, Unit = Units.Metre},
                new() {Value = -0.000001m, Unit = Units.Metre}
            },

            // Not convertible
            new UnitValue?[]
            {
                new() {Value = 1, Unit = Units.Bag},
                new() {Value = 2, Unit = Units.Bag},
                new() {Value = -1, Unit = Units.Bag}
            },
        };

    public static IEnumerable<object?[]> DivisionOperatorData =>
        new List<UnitValue?[]>
        {
            new UnitValue?[]
            {
                new() {Value = 1m, Unit = Units.Metre},
                new() {Value = 2m, Unit = Units.Metre},
                new() {Value = 0.5m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 1e6m, Unit = Units.Metre},
                new() {Value = 2m, Unit = Units.Centimetre},
                new() {Value = 50e6m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 106.6m, Unit = Units.Centimetre},
                new() {Value = 1.065m, Unit = Units.Metre},
                new() {Value = 1.00093897m, Unit = Units.Centimetre},
            },
            new UnitValue?[]
            {
                new() {Value = 1.065m, Unit = Units.Metre},
                new() {Value = 106.6m, Unit = Units.Centimetre},
                new() {Value = 0.999061914m, Unit = Units.Metre},
            },
            new UnitValue?[]
            {
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = -106.6m, Unit = Units.Centimetre},
                new() {Value = 0, Unit = Units.Metre},
            },
            // Both operands are zero
            new UnitValue?[]
            {
                new() {Value = 0m, Unit = Units.Metre},
                new() {Value = 0m, Unit = Units.Metre},
                null,
            },
            // Zero division
            new UnitValue?[]
            {
                new() {Value = 1m, Unit = Units.Metre},
                new() {Value = 0m, Unit = Units.Metre},
                null,
            },
            // One value is negative
            new UnitValue?[]
            {
                new() {Value = 1m, Unit = Units.Metre},
                new() {Value = -2m, Unit = Units.Metre},
                new() {Value = -0.5m, Unit = Units.Metre}
            },
            // Both values are negative
            new UnitValue?[]
            {
                new() {Value = -1m, Unit = Units.Metre},
                new() {Value = -2m, Unit = Units.Metre},
                new() {Value = 0.5m, Unit = Units.Metre}
            },
            // Large numbers
            new UnitValue?[]
            {
                new() {Value = 1e6m, Unit = Units.Metre},
                new() {Value = 2e6m, Unit = Units.Metre},
                new() {Value = 0.5m, Unit = Units.Metre}
            },

            // Small numbers
            new UnitValue?[]
            {
                new() {Value = 0.000001m, Unit = Units.Metre},
                new() {Value = 0.000002m, Unit = Units.Metre},
                new() {Value = 0.5m, Unit = Units.Metre}
            },
            // Not convertible
            new UnitValue?[]
            {
                new() {Value = 1, Unit = Units.Bag},
                new() {Value = 2, Unit = Units.Bag},
                new() {Value = 0.5m, Unit = Units.Bag}
            },
        };

    public static IEnumerable<object?[]> MultiplicationOperatorData =>
        new List<object?[]>
        {
            new object?[]
            {
                new UnitValue {Value = 1m, Unit = Units.Metre},
                2m,
                new UnitValue {Value = 2m, Unit = Units.Metre},
            },
            new object?[]
            {
                new UnitValue {Value = 1e6m, Unit = Units.Metre},
                2m,
                new UnitValue {Value = 2e6m, Unit = Units.Metre},
            },
            new object?[]
            {
                new UnitValue {Value = 2m, Unit = Units.Centimetre},
                100m,
                new UnitValue {Value = 2e2m, Unit = Units.Centimetre},
            },
            new object?[]
            {
                new UnitValue {Value = 1.065m, Unit = Units.Metre},
                1.066m,
                new UnitValue {Value = 1.13529m, Unit = Units.Metre},
            },
            new object?[]
            {
                new UnitValue {Value = 0m, Unit = Units.Metre},
                -1.066m,
                new UnitValue {Value = 0m, Unit = Units.Metre},
            },
            // Both operands are zero
            new object?[]
            {
                new UnitValue {Value = 0m, Unit = Units.Metre},
                0,
                new UnitValue {Value = 0m, Unit = Units.Metre}
            },
            // One operand is zero, the other is not
            new object?[]
            {
                new UnitValue {Value = 0m, Unit = Units.Metre},
                1,
                new UnitValue {Value = 0m, Unit = Units.Metre}
            },
            // Both values are negative
            new object?[]
            {
                new UnitValue {Value = -1m, Unit = Units.Metre},
                -2,
                new UnitValue {Value = 2m, Unit = Units.Metre}
            },
            // Large numbers
            new object?[]
            {
                new UnitValue {Value = 1e6m, Unit = Units.Metre},
                2e6m,
                new UnitValue {Value = 2e12m, Unit = Units.Metre}
            },
            // Small numbers
            new object?[]
            {
                new UnitValue {Value = 1e-6m, Unit = Units.Metre},
                2e-6m,
                new UnitValue {Value = 2e-12m, Unit = Units.Metre}
            },
        };

    #endregion
}
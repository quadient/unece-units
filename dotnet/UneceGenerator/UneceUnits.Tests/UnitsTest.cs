using FluentAssertions;

namespace UneceUnits.Tests;

public class UnitsTest
{
    [Fact]
    public void GetByCommonCode_GivenNonExistingCode_ShouldThrow()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => { Units.GetByCommonCode("NOT EXISTING"); });
    }
    
    [Theory]
    [InlineData("NOT EXISTING", false)]
    [InlineData("KMT", true)]
    [InlineData("XAJ", true)]
    public void TryGetByCommonCode_GivenCode_ShouldReturnProperResult(string commonCode, bool expected)
    {
        Units.TryGetByCommonCode(commonCode, out _).Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetByCommonCodeData))]
    public void TryGetByCommonCode_GivenCode_ShouldReturnProperUnit(string commonCode, IUnit expected)
    {
        Units.GetByCommonCode(commonCode).Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(GetConvertibleByCommonCodeData))]
    public void TryGetConvertibleByCommonCode_GivenCode_ShouldReturnProperUnitIfConvertible(string commonCode,
        IUnit? expectedUnit)
    {
        Units.TryGetConvertibleByCommonCode(commonCode, out var expected).Should().Be(expectedUnit != null);
        expected.Should().BeEquivalentTo(expectedUnit);
    }

    [Theory]
    [MemberData(nameof(GetConvertibleByCommonCodeData))]
    public void GetConvertibleByCommonCode_GivenCode_ShouldReturnProperUnitIfConvertible(string commonCode,
        IUnit? expectedUnit)
    {
        if (expectedUnit == null)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { Units.GetConvertibleByCommonCode(commonCode); });
            return;
        }

        Units.GetConvertibleByCommonCode(commonCode).Should().Be(expectedUnit);
    }

    public static IEnumerable<object[]> GetByCommonCodeData()
    {
        yield return new object[] {"KMT", Units.Kilometre};
        yield return new object[] {"MTR", Units.Metre};
        yield return new object[] {"XAJ", Units.Cone};
    }

    public static IEnumerable<object?[]> GetConvertibleByCommonCodeData()
    {
        yield return new object?[] {"KMT", Units.Kilometre};
        yield return new object?[] {"MTR", Units.Metre};
        yield return new object?[] {"XAJ", null};
        yield return new object?[] {"NOT EXISTING", null};
    }
}
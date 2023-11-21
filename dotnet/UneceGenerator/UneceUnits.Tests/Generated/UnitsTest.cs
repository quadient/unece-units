using FluentAssertions;
using UneceUnits;

namespace UneceUnits.Tests.Generated;

public class UnitsGeneratedTest
{
    [Fact]
    public void GetByCommonCode_GivenNonExistingCode_ShouldThrow()
    {
        Assert.Throws<ArgumentException>(() => { Units.GetByCommonCode("NOT EXISTING"); });
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
    [MemberData(nameof(TryGetConvertibleByCommonCodeData))]
    public void TryGetConvertibleByCommonCode_GivenCode_ShouldReturnProperUnitIfConvertible(string commonCode, IUnit? expectedUnit, bool expectedResult)
    {
        Units.TryGetConvertibleByCommonCode(commonCode, out var expected).Should().Be(expectedResult);
        expected.Should().BeEquivalentTo(expectedUnit);
    }
    
    public static IEnumerable<object[]> GetByCommonCodeData()
    {
        yield return new object[] {"KMT", Units.Kilometre};
        yield return new object[] {"MTR", Units.Metre};
        yield return new object[] {"XAJ", Units.Cone};
    }
    
    public static IEnumerable<object?[]> TryGetConvertibleByCommonCodeData()
    {
        yield return new object?[] {"KMT", Units.Kilometre, true};
        yield return new object?[] {"MTR", Units.Metre, true};
        yield return new object?[] {"XAJ", null, false};
        yield return new object?[] {"NOT EXISTING", null, false};
    }
}
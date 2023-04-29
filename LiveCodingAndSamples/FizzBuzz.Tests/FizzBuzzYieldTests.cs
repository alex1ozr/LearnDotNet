using FluentAssertions;
using LearnDotNet.FizzBuzz.Implementations;
using Xunit;

namespace LearnDotNet.FizzBuzz.Tests;

public class FizzBuzzYieldTests
{
    private readonly IFizzBuzz sut = new FizzBuzzYield();

    [Theory]
    [MemberData(nameof(TestData.GetFizzBuzzSingleItemTestData), MemberType = typeof(TestData))]
    public void ConvertToFizzBuzz_ShouldReturn(int inputNum, string expectedResult)
    {
        var result = sut.ConvertToFizzBuzz(new[] { inputNum });

        result.Should().BeEquivalentTo(expectedResult);
    }
    
    [Fact]
    public void ConvertToFizzBuzz_Top100_ShouldReturn()
    {
        var result = sut.ConvertToFizzBuzz(Enumerable.Range(1, 100));

        result.Should().BeEquivalentTo(TestData.FizzBuzzOutputFor100Items);
    }
}
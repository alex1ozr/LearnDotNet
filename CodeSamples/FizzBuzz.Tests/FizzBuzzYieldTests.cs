using FluentAssertions;
using LearnDotNet.FizzBuzz;
using LearnDotNet.FizzBuzz.Implementations;
using Xunit;

namespace FizzBuzz.Tests;

public class FizzBuzzYieldTests
{
    private readonly IFizzBuzz sut = new FizzBuzzYield();

    [Theory]
    [MemberData(nameof(TestData.GetFizzBuzzTestData), MemberType = typeof(TestData))]
    public void ConvertToFizzBuzz_ShouldReturn(int inputNum, string expectedResult)
    {
        var result = sut.ConvertToFizzBuzz(new[] { inputNum });

        result.Should().BeEquivalentTo(expectedResult);
    }
}
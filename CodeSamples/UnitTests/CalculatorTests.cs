using FluentAssertions;
using LearnDotNet.UnitTests.Calculator;
using LearnDotNet.UnitTests.Calculator.Exceptions;
using Xunit;

namespace LearnDotNet.UnitTests;

public class CalculatorTests
{
    private readonly ICalculatorService sut;

    public CalculatorTests()
    {
        sut = new CalculatorService();
    }

    [Fact(DisplayName = "Summarize 2 and 2. Should return 4")]
    public void Sum_ShouldSummarize()
    {
        // Arrange
        var service = new CalculatorService();

        // Act
        var result = service.Sum(2, 2);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(4, result.Value);
    }

    [Fact(DisplayName = "Subtract 5 and 3. Should return 2")]
    public void Subtract_ShouldSubtract()
    {
        var result = sut.Subtract(5, 3);
        result.Should().NotBeNull();
        result.Value.Should().Be(2);
    }

    [Fact(DisplayName = "Multiply 3 and 9. Should return 27")]
    public void Multiply_ShouldMultiply()
    {
        var result = sut.Multiply(3, 9);
        result.Should().BeEquivalentTo(new
        {
            Value = 27
        });
    }

    [Theory(DisplayName = "Divide two decimal numbers. Should divide")]
    [MemberData(nameof(DivisionTestData))]
    public void Divide_ShouldDivide(decimal dividend, decimal divisor, decimal expectedResult)
    {
        var result = sut.Divide(dividend, divisor);
        result.Should()
            .NotBeNull()
            .And
            .BeEquivalentTo(new
            {
                Value = expectedResult
            });
    }

    [Theory(DisplayName = "Modulation of two integer numbers. Should calculate")]
    [InlineData(5, 2, 1)]
    [InlineData(2, 2, 0)]
    public void Modulo_ShouldModulo(int dividend, int divisor, int expectedResult)
    {
        var result = sut.Modulo(dividend, divisor);
        result.Should()
            .BeEquivalentTo(new
            {
                Value = expectedResult
            });
    }

    [Fact(DisplayName = "Divide by zero. Should throw")]
    public void Divide_ByZero_ShouldThrow()
    {
        Action action = () => sut.Divide(5, 0);
        action
            .Should().Throw<DivisionByZeroException>()
            .WithMessage("OMG! You try to divide by zero!");
    }

    public static IEnumerable<object[]> DivisionTestData()
    {
        yield return new object[] { 9M, 3M, 3M };
        yield return new object[] { 120M, 2M, 60M };
    }
}
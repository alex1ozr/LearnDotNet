using FluentAssertions;
using LearnDotNet.UnitTests.Calculator;
using LearnDotNet.UnitTests.Calculator.Abstract;
using LearnDotNet.UnitTests.Calculator.Models;
using Moq;
using Xunit;

namespace LearnDotNet.UnitTests;

public class ComplexCalculationServiceTests
{
    private readonly IComplexCalculationService sut;
    private readonly Mock<ICalculatorService> calculatorServiceMock;

    public ComplexCalculationServiceTests()
    {
        calculatorServiceMock = new Mock<ICalculatorService>();
        
        sut = new ComplexCalculationService(calculatorServiceMock.Object);
    }

    [Fact]
    public void PerformComplexCalculation_ShouldPerform()
    {
        // Arrange
        calculatorServiceMock.Setup(x => x.Multiply(100M, 3M))
            .Returns(new CalculationResult(300M));
        calculatorServiceMock.Setup(x => x.Subtract(100M, 3M))
            .Returns(new CalculationResult(97M));

        // Act
        var result = sut.PerformComplexCalculation(100M, 3M);

        // Assert
        result.Should().Be("Multiplication:300; Difference:97");
    }
}
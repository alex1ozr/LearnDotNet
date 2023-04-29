using System.Globalization;
using LearnDotNet.UnitTests.Calculator.Abstract;
using LearnDotNet.UnitTests.Calculator.Models;

namespace LearnDotNet.UnitTests.Calculator;

internal class ComplexCalculationService : IComplexCalculationService
{
    private readonly ICalculatorService calculatorService;

    public ComplexCalculationService(ICalculatorService calculatorService)
    {
        this.calculatorService = calculatorService;
    }

    public string PerformComplexCalculation(decimal num1, decimal num2)
    {
        var multiplication = calculatorService.Multiply(num1, num2);
        var difference = calculatorService.Subtract(num1, num2);

        return $"Multiplication:{CalculationResultToString(multiplication)}; "
               + $"Difference:{CalculationResultToString(difference)}";
    }

    private static string CalculationResultToString(CalculationResult calculationResult)
        => calculationResult.Value.ToString("0.###", CultureInfo.InvariantCulture);
}
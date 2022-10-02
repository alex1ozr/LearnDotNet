using LearnDotNet.UnitTests.Calculator.Models;

namespace LearnDotNet.UnitTests.Calculator.Abstract;

internal interface ICalculatorService
{
    CalculationResult Sum(decimal augend, decimal addend);

    CalculationResult Subtract(decimal minuend, decimal subtrahend);
    
    CalculationResult Multiply(decimal multiplicand, decimal multiplier);
    
    /// <exception cref="DivideByZeroException">...</exception>
    CalculationResult Divide(decimal dividend, decimal divisor);

    CalculationResult Modulo(int dividend, int divisor);
}
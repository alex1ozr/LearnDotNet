namespace LearnDotNet.UnitTests.Calculator;

internal interface ICalculatorService
{
    CalculationResult Sum(decimal augend, decimal addend);

    CalculationResult Subtract(decimal minuend, decimal subtrahend);
    
    CalculationResult Multiply(decimal multiplicand, decimal multiplier);
    
    CalculationResult Divide(decimal dividend, decimal divisor);

    CalculationResult Modulo(int dividend, int divisor);
}
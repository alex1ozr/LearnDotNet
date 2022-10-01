using LearnDotNet.UnitTests.Calculator.Exceptions;

namespace LearnDotNet.UnitTests.Calculator;

internal class CalculatorService : ICalculatorService
{
    public CalculationResult Sum(decimal augend, decimal addend)
        => new CalculationResult(augend + addend);

    public CalculationResult Subtract(decimal minuend, decimal subtrahend)
        => new CalculationResult(minuend - subtrahend);

    public CalculationResult Multiply(decimal multiplicand, decimal multiplier)
        => new CalculationResult(multiplicand * multiplier);

    public CalculationResult Divide(decimal dividend, decimal divisor)
    {
        if (divisor == 0)
        {
            throw new DivisionByZeroException();
        }
        
        return new CalculationResult(dividend / divisor);
    }

    public CalculationResult Modulo(int dividend, int divisor)
        => new CalculationResult(dividend % divisor);
}
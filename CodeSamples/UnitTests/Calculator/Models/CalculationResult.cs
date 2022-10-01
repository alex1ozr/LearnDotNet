namespace LearnDotNet.UnitTests.Calculator.Models;

internal class CalculationResult
{
    public decimal Value { get; }
    
    public CalculationResult(decimal value)
    {
        Value = value;
    }
}
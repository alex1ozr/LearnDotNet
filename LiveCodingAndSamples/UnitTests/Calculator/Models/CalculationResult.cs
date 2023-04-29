namespace LearnDotNet.UnitTests.Calculator.Models;

internal sealed class CalculationResult
{
    public decimal Value { get; }
    
    public CalculationResult(decimal value)
    {
        Value = value;
    }
}
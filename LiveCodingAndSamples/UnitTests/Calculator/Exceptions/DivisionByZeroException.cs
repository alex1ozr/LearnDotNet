namespace LearnDotNet.UnitTests.Calculator.Exceptions;

internal class DivisionByZeroException : Exception
{
    public DivisionByZeroException()
        : base("OMG! You try to divide by zero!")
    {
    }
}
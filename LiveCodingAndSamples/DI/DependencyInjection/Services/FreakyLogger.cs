using LearnDotNet.DependencyInjection.Abstract;

namespace LearnDotNet.DependencyInjection.Services;

internal sealed class FreakyLogger : IFreakyLogger
{
    public void Log(string message)
    {
        Console.WriteLine("FreakyLogger is speaking: " + message);
    }
}
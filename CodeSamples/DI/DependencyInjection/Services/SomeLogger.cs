using LearnDotNet.DependencyInjection.Abstract;

namespace LearnDotNet.DependencyInjection.Services;

internal sealed class SomeLogger : ISomeLogger
{
    public void Log(string message)
    {
        Console.WriteLine("SomeLogger is speaking: " + message);
    }
}
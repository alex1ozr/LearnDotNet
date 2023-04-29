namespace LearnDotNet.DependencyInjection.Abstract;

internal interface ISomeLogger: ILogger
{
    void Log(string message);
}
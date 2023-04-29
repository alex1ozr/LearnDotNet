namespace LearnDotNet.DependencyInjection.Abstract;

internal interface IFreakyLogger: ILogger
{
    void Log(string message);
}
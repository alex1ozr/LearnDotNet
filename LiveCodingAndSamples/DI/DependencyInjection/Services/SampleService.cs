namespace LearnDotNet.DependencyInjection.Services;

internal sealed class SampleService : ISampleService
{
    public SampleService()
    {
        
    }
    
    public void DoSomething()
    {
        Console.WriteLine("Hello, World!");
    }
}
namespace LearnDotNet.WebAppSample.Services;

public interface ISampleService: IService
{
    string GetValue { get; }
}
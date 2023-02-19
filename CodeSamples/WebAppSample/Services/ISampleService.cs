namespace WebAppSample.Services;

public interface ISampleService: IService
{
    string GetValue { get; }
}
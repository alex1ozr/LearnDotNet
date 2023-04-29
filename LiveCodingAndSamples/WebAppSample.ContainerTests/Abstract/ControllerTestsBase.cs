using Xunit;

namespace LearnDotNet.WebAppSample.ContainerTests.Abstract;

[Collection(IntegrationTestCollection.Name)]
public abstract class ControllerTestsBase: IAsyncLifetime
{
    protected readonly HttpClient HttpClient;

    protected ControllerTestsBase(TestApplication apiFactory)
    {
        HttpClient = apiFactory.HttpClient;
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => Task.CompletedTask;
}
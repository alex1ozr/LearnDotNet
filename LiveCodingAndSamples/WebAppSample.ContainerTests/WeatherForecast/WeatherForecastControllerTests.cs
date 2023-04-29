using FluentAssertions;
using LearnDotNet.WebAppSample.Client.Generated.Implementations;
using LearnDotNet.WebAppSample.ContainerTests.Abstract;
using Xunit;

namespace LearnDotNet.WebAppSample.ContainerTests.WeatherForecast;

public sealed class WeatherForecastControllerTests : ControllerTestsBase
{
    private readonly IWeatherForecastClient _client;
    
    public WeatherForecastControllerTests(TestApplication apiFactory) 
        : base(apiFactory)
    {
        _client = new WeatherForecastClient(HttpClient);
    }

    [Fact(DisplayName = "...")]
    public async Task SaveWeatherForecast_ShouldSave()
    {
        var result = await _client.SaveWeatherForecastAsync(200, new MyClass
        {
            Value = "test",
            IntValue = 200,
        }, CancellationToken.None);

        result.Should().HaveCount(1);
        result.Should().Contain(200);
    }
} 
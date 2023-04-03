using Microsoft.Extensions.DependencyInjection;

namespace LearnDotNet.WebAppSample.Client.Generated.Implementations;

internal partial class WeatherForecastClient
{
    [ActivatorUtilitiesConstructor]
    public WeatherForecastClient(
        HttpClient httpClient)
        : this(httpClient.BaseAddress?.OriginalString
               ?? throw new ArgumentNullException(""),
            httpClient)
    {
    }
}
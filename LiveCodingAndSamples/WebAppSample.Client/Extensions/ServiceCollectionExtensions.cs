using LearnDotNet.WebAppSample.Client.Generated.Implementations;
using LearnDotNet.WebAppSample.Client.Manual;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherForecastClient = LearnDotNet.WebAppSample.Client.Generated.Implementations.WeatherForecastClient;

namespace LearnDotNet.WebAppSample.Client.Extensions;

public static class ServiceCollectionExtensions
{
    public static ServiceCollection AddGeneratedForecastClient(this ServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient<IWeatherForecastClient, WeatherForecastClient>((provider,client) =>
        {
            var config = provider.GetRequiredService<IConfiguration>();

            client.BaseAddress = config.GetSection(WeatherForecastClientOptions.WeatherForecast)
                                     .Get<WeatherForecastClientOptions>()
                                     ?.HostUri
                                 ?? throw new InvalidOperationException(
                                     $"Не задано значение {nameof(WeatherForecastClientOptions.HostUri)}");
        });

        return serviceCollection;
    }
    
    public static ServiceCollection AddManualForecastClient(this ServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient<IManualForecastClient, ManualForecastClient>((provider,client) =>
        {
            var config = provider.GetRequiredService<IConfiguration>();

            client.BaseAddress = config.GetSection(WeatherForecastClientOptions.WeatherForecast)
                                     .Get<WeatherForecastClientOptions>()
                                     ?.HostUri
                                 ?? throw new InvalidOperationException(
                                     $"Не задано значение {nameof(WeatherForecastClientOptions.HostUri)}");
        });

        return serviceCollection;
    }
    
    public static ServiceCollection AddConfiguration(this ServiceCollection serviceCollection)
    {
        IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            return builder.Build();
        }

        var configuration = GetConfiguration();
        serviceCollection.AddScoped<IConfiguration>(_ => configuration);

        return serviceCollection;
    }
}
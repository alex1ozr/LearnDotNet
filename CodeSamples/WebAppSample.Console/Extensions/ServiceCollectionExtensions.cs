using LearnDotNet.WebAppSample.Console.Clients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LearnDotNet.WebAppSample.Console.Extensions;

public static class ServiceCollectionExtensions
{
    public static ServiceCollection AddWeatherForecastClient(this ServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IForecastClient, ForecastClient>();
        serviceCollection.AddHttpClient<ForecastClient>((provider,client) =>
        {
            var config = provider.GetRequiredService<IConfiguration>();
            client.BaseAddress = config.GetSection("WeatherForecast:HostUri").Get<Uri>();
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
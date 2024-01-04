using Microsoft.Extensions.DependencyInjection;

namespace LearnDotNet.ExperimentsConsoleApp.Options;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSomeOptionsService(this IServiceCollection services)
    {
        services.AddOptions<SomeOptions>()
            .BindConfiguration(SomeOptions.SectionName)
            .ValidateDataAnnotations();
        
        services.AddTransient<ISomeOptionsService, SomeOptionsService>();
        
        return services;
    }
}
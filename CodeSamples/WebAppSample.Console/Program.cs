using LearnDotNet.WebAppSample.Client.Extensions;
using LearnDotNet.WebAppSample.Client.Generated.Implementations;
using LearnDotNet.WebAppSample.Client.Manual;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddConfiguration();
serviceCollection.AddWeatherForecastClient();
serviceCollection.AddGeneratedWeatherForecastClient();
var serviceProvider = serviceCollection.BuildServiceProvider();

var client = serviceProvider.GetRequiredService<ForecastClient>();
var generatedClient = serviceProvider.GetRequiredService<WeatherForecastClient>();

var id = 200;
var result = await client.PostAsync(id, CancellationToken.None);
var resultFromGeneratedClient = await generatedClient.SaveWeatherForecastAsync(id, new MyClass
{
    Value = "tets",
    IntValue = id,
}, CancellationToken.None);

Console.ReadKey();


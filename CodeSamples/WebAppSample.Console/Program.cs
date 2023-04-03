using LearnDotNet.WebAppSample.Client.Extensions;
using LearnDotNet.WebAppSample.Client.Generated.Implementations;
using LearnDotNet.WebAppSample.Client.Manual;
using Microsoft.Extensions.DependencyInjection;

using MyClassGenerated  = LearnDotNet.WebAppSample.Client.Generated.Implementations.MyClass;
using MyClassManual = LearnDotNet.WebAppSample.Client.Manual.Models.MyClass;

var serviceCollection = new ServiceCollection();
serviceCollection.AddConfiguration();
serviceCollection.AddManualForecastClient();
serviceCollection.AddGeneratedForecastClient();
var serviceProvider = serviceCollection.BuildServiceProvider();

var manualClient = serviceProvider.GetRequiredService<IManualForecastClient>();
var generatedClient = serviceProvider.GetRequiredService<IWeatherForecastClient>();

var id = 200;
var resultFromManualClient = await manualClient.PostAsync(id, new MyClassManual
{
    Value = "test",
    IntValue = id,
}, CancellationToken.None);

var resultFromGeneratedClient = await generatedClient.SaveWeatherForecastAsync(id, new MyClassGenerated
{
    Value = "test",
    IntValue = id,
}, CancellationToken.None);

Console.ReadKey();


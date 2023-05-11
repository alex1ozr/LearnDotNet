using LearnDotNet.WebAppSample.Client;
using LearnDotNet.WebAppSample.Client.Extensions;
using LearnDotNet.WebAppSample.Client.Generated.Implementations;
using LearnDotNet.WebAppSample.Client.Manual;
using LearnDotNet.WebAppSample.Console.Extensions;
using LearnDotNet.WebAppSample.Console.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyClassGenerated  = LearnDotNet.WebAppSample.Client.Generated.Implementations.MyClass;
using MyClassManual = LearnDotNet.WebAppSample.Client.Manual.Models.MyClass;

var serviceCollection = new ServiceCollection();
serviceCollection.AddConfiguration()
    .AddManualForecastClient()
    .AddGeneratedForecastClient();

serviceCollection.AddOptions<OptionsSample>()
    .BindConfiguration(OptionsSample.OptionKey)
    .ValidateDataAnnotations(); // IOptions registration sample

var serviceProvider = serviceCollection.BuildServiceProvider();

var sampleOptions = serviceProvider.GetRequiredService<IOptions<OptionsSample>>();
Console.WriteLine("Sample options value: " + sampleOptions.Value.Value);

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


using LearnDotNet.WebAppSample.Console.Clients;
using LearnDotNet.WebAppSample.Console.Extensions;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddConfiguration();
serviceCollection.AddWeatherForecastClient();
var serviceProvider = serviceCollection.BuildServiceProvider();

var client = serviceProvider.GetRequiredService<ForecastClient>();

var result = await client.PostAsync(200, CancellationToken.None);

Console.ReadKey();


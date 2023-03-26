namespace LearnDotNet.WebAppSample.Console.Clients;

public sealed class WeatherForecastClientOptions
{
    public static readonly string WeatherForecast = "WeatherForecast";
    
    public Uri? HostUri { get; set; }
}
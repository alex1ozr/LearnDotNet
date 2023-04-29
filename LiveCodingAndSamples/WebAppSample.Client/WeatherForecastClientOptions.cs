namespace LearnDotNet.WebAppSample.Client;

public sealed class WeatherForecastClientOptions
{
    public static readonly string WeatherForecast = "WeatherForecast";
    
    public Uri? HostUri { get; set; }
}
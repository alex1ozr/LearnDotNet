namespace LearnDotNet.WebAppSample.Console.Clients;

public interface IForecastClient
{
    Task<int[]?> PostAsync(int id, CancellationToken ct = default);
}
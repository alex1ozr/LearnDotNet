namespace LearnDotNet.WebAppSample.Client.Manual;

public interface IForecastClient
{
    Task<int[]?> PostAsync(int id, CancellationToken ct = default);
}
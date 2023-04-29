using LearnDotNet.WebAppSample.Client.Manual.Models;

namespace LearnDotNet.WebAppSample.Client.Manual;

public interface IManualForecastClient
{
    Task<int[]?> PostAsync(int id, MyClass data, CancellationToken ct = default);
}
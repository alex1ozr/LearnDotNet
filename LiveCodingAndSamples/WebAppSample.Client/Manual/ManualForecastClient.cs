using System.Net.Http.Json;
using LearnDotNet.WebAppSample.Client.Manual.Models;

namespace LearnDotNet.WebAppSample.Client.Manual;

internal sealed class ManualForecastClient : IManualForecastClient
{
    private readonly HttpClient _client;

    public ManualForecastClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<int[]?> PostAsync(int id, MyClass data, CancellationToken ct)
    {
        var result = await _client.PostAsJsonAsync(
            requestUri: $"/api/v1/weather-forecasts/cities/{id}",
            data, cancellationToken: ct);

        return await result.Content.ReadFromJsonAsync<int[]>(cancellationToken: ct);
    }
}
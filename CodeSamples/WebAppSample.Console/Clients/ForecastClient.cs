using System.Net.Http.Json;

namespace LearnDotNet.WebAppSample.Console.Clients;

public class ForecastClient : IForecastClient
{
    private readonly HttpClient _client;

    public ForecastClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<int[]?> PostAsync(int id, CancellationToken ct)
    {
        var result = await _client.PostAsJsonAsync(requestUri: $"/api/v1/weather-forecasts/cities/{id}", 
            new { Value = "tets", IntValue = id}, cancellationToken: ct);

        return await result.Content.ReadFromJsonAsync<int[]>(cancellationToken: ct);
    }
}
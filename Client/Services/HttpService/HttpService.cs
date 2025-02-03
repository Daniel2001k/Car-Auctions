using System.Net.Http.Json;

namespace CarAuctions.Client.Services.HttpService;

internal class HttpService(IHttpClientFactory httpClientFactory) : IHttpService
{
    private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;

    public async Task<T> Get<T>(string url)
    {
        var httpClient = _httpClientFactory.CreateClient("WebAPI");
        var response = await httpClient.GetAsync(url);
        if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
        {
            return default(T);
        }

        var result = await response.Content.ReadFromJsonAsync<T>();

        return result;
    }
    public async Task<HttpResponseMessage> Post(string url, object data)
    {
        var httpClient = _httpClientFactory.CreateClient("WebAPI");
        return await httpClient.PostAsJsonAsync(url, data);
    }
}
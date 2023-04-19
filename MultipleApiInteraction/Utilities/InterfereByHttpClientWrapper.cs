using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace MultipleApiInteraction.Utilities;

public class InterfereByHttpClientWrapper
{
    private readonly HttpClient _httpClient;

    public InterfereByHttpClientWrapper(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T?> GetAsync<T>(string requestUrl)
    {
        Console.WriteLine($"{nameof(InterfereByHttpClientWrapper)} interfere BEFORE sending request");
        var response = await _httpClient.GetFromJsonAsync<T>(requestUrl);
        Console.WriteLine($"{nameof(InterfereByHttpClientWrapper)} interfere AFTER sending request");

        return response;
    }
}
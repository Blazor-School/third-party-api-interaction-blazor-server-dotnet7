namespace MultipleApiInteraction.Utilities;

public static class HttpClientExtension
{
    public static async Task<T?> GetResponse<T>(this HttpClient httpClient, string url)
    {
        Console.WriteLine($"{nameof(HttpClientExtension)} interfere BEFORE sending request");
        var result = await httpClient.GetFromJsonAsync<T>(url);
        Console.WriteLine($"{nameof(HttpClientExtension)} interfere AFTER sending request");

        return result;
    }
}
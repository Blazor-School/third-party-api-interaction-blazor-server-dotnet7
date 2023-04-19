namespace MultipleApiInteraction.Utilities;

public class SecondMiddleware : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"{nameof(SecondMiddleware)} interfere BEFORE sending request");
        var response = await base.SendAsync(request, cancellationToken);
        Console.WriteLine($"{nameof(SecondMiddleware)} interfere AFTER sending request");

        return response;
    }
}
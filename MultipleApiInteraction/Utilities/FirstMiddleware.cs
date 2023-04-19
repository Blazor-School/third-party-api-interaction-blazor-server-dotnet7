namespace MultipleApiInteraction.Utilities;
public class FirstMiddleware : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"{nameof(FirstMiddleware)} interfere BEFORE sending request");
        var response = await base.SendAsync(request, cancellationToken);
        Console.WriteLine($"{nameof(FirstMiddleware)} interfere AFTER sending request");

        return response;
    }
}

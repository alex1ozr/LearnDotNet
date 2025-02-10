# Request Processor
Implement a request processor that sends requests and receives responses from a network adapter.

Solutions:
    - https://github.com/asm-jaime/CsharpByTDD/blob/8667f7732ac760b40515d1475d4be263677b7500/csharp.TPL.request-processor/solution.cs
    - https://github.com/DiCollars/CSharp_Learning/blob/5b88f283f81433031371100f88819e42220a6c6e/CSHARP_LEARNING/Interviews/TaskCompleteSource/Program.cs

```csharp
public record Request(Guid Id); // Some other fields

public record Response(Guid Id); // Some other fields

public interface INetworkAdapter
{
    /// Reads the next response
    Task<Response> ReadAsync(CancellationToken cancellationToken);

    /// Enqueues the next request for sending. false - the queue is full, the request will not be sent
    bool TryEnqueueWrite(Request request, CancellationToken cancellationToken);

    /// Sends the request
    Task WriteAsync(Request request, CancellationToken cancellationToken);
}

public interface IRequestProcessor
{
    Task StopAsync(CancellationToken cancellationToken);

    Task<Response> SendAsync(Request request, CancellationToken cancellationToken);
}

public class RequestProcessor : IRequestProcessor
{
    private readonly INetworkAdapter _networkAdapter;

    public RequestProcessor(INetworkAdapter networkAdapter)
    {
        _networkAdapter = networkAdapter;
    }

    public async Task RunAsync(CancellationToken cancellationToken)
    {
    }

    public async Task<Response> SendAsync(Request request, CancellationToken cancellationToken)
    {
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
    }
}
```
using Microsoft.Extensions.Options;

namespace LearnDotNet.ExperimentsConsoleApp.Options;

internal sealed class SomeOptionsService : ISomeOptionsService
{
    private readonly IOptions<SomeOptions> options;

    public SomeOptionsService(IOptions<SomeOptions> options)
    {
        this.options = options;
    }
    
    public void WriteOptions()
    {
        Console.WriteLine($"Options value: {options.Value.Value}");
    }
}
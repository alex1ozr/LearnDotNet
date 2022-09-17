namespace Singleton;

public sealed class LazySingleton
{
    private static readonly Lazy<LazySingleton> instance = new(() => new LazySingleton());

    private LazySingleton() { }
    
    public static LazySingleton Instance => instance.Value;
}
namespace LearnDotNet.Singleton;

public sealed class FieldInitSingleton
{
    private static readonly FieldInitSingleton instance;

    private FieldInitSingleton() { }

    static FieldInitSingleton()
    {
        instance = new FieldInitSingleton();
    }
    
    public static FieldInitSingleton Instance => instance;
}
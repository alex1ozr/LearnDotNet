namespace Singleton;

internal class ClassicSingleton
{
    private static ClassicSingleton? instance;

    private ClassicSingleton() { }

    public static ClassicSingleton GetInstance()
    {
        if (instance == null)
        {
            instance = new ClassicSingleton();
        }

        return instance;
    }
}
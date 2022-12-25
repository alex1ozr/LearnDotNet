namespace LearnDotNet.Singleton;

// TODO Лучше так не писать - работает только в однопоточном приложении
internal sealed class ClassicSingleton
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
namespace Singleton;

public sealed class DoubleCheckedLockSingleton
{
    private static readonly object syncRoot = new();
    private static volatile DoubleCheckedLockSingleton? instance;

    private DoubleCheckedLockSingleton() { }
    
    public static DoubleCheckedLockSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new DoubleCheckedLockSingleton();
                    }
                }
            }

            return instance;
        }
    }
}
// Singleton
// Порождающий шаблон проектирования, гарантирующий, что в однопоточном приложении будет единственный экземпляр некоторого класса,
// и предоставляющий глобальную точку доступа к этому экземпляру.

using Singleton;

Console.WriteLine($"{ClassicSingleton.GetInstance()} created");
Console.WriteLine($"{DoubleCheckedLockSingleton.Instance} created");
Console.WriteLine($"{FieldInitSingleton.Instance} created");
Console.WriteLine($"{LazySingleton.Instance} created");
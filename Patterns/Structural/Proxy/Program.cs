// Proxy (Заместитель)
// Структурный шаблон проектирования, предоставляющий объект, который контролирует доступ к другому объекту, перехватывая все вызовы (выполняет функцию контейнера).
// Не путать с декоратором! Декоратор добавляет новое поведение, позволяя нанизывать его слоями. 
// Заместитель же выполняет ровно те же операции, что и оригинальный объект, но, в то же время, может его создавать лишь при необходимости, разгружая систему.

var serviceProxy = new ServiceProxy();

serviceProxy.DoSomething();

internal interface IService
{
    void DoSomething();
}

internal class ConcreteService : IService
{
    public void DoSomething()
    {
        Console.WriteLine($"Some operation was performed by {GetType().Name}");
    }
}

internal class ServiceProxy : IService
{
    private IService? service;

    public void DoSomething()
    {
        if (service is null)
        {
            service = new ConcreteService();
            Console.WriteLine($"{service.GetType().Name} was created on first call");
        }
        
        service.DoSomething();
    }
}
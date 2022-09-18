// Decorator
// Структурный шаблон проектирования, предназначенный для динамического подключения дополнительного поведения к объекту.
// Шаблон Декоратор предоставляет гибкую альтернативу практике создания подклассов с целью расширения функциональности.

var service = new ConcreteService();
var decorator = new ServiceDecorator(service);

service.DoSomething();
decorator.DoSomething();

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

internal class ServiceDecorator : IService
{
    private readonly IService service;

    public ServiceDecorator(IService service)
    {
        this.service = service;
    }

    public void DoSomething()
    {
        Console.WriteLine("Decorator is speaking");
        service.DoSomething();
        Console.WriteLine("Decorator performs some other operation");
    }
}

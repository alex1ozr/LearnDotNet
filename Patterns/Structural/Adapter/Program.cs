// Adapter
// Структурный шаблон проектирования, предназначенный для организации использования функций объекта,
// недоступного для модификации, через специально созданный интерфейс.
// Позволяет объектам с несовместимыми интерфейсами работать вместе.

var service = new ExternalService();
IService serviceAdapter = new ServiceAdapter(service);

serviceAdapter.Execute();


internal sealed class ExternalService
{
    public void DoSomething() => Console.WriteLine($"{nameof(ExternalService)} performs some action");
}

internal interface IService // Адаптируем ExternalService к интерфейсу IService
{
    void Execute();
}

internal class ServiceAdapter : IService
{
    private readonly ExternalService service;

    public ServiceAdapter(ExternalService service)
    {
        this.service = service;
    }
    
    public void Execute() => service.DoSomething();
}
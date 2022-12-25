// Facade
// Структурный шаблон проектирования, позволяющий скрыть сложность системы путём сведения всех возможных внешних вызовов
// к одному объекту, делегирующему их соответствующим объектам системы.

var facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());

facade.Operation1();
facade.Operation2();


internal class SubsystemA
{
    public void ExecuteA1() => Console.WriteLine($"{GetType().Name} executes method 1");
    
    public void ExecuteA2() => Console.WriteLine($"{GetType().Name} executes method 2");
}

internal class SubsystemB
{
    public void ExecuteB1() => Console.WriteLine($"{GetType().Name} executes some method");
}

internal class SubsystemC
{
    public void ExecuteC1() => Console.WriteLine($"{GetType().Name} executes method 1");
    
    public void ExecuteC2() => Console.WriteLine($"{GetType().Name} executes method 2");
}

internal class Facade
{
    private readonly SubsystemA subsystemA;
    private readonly SubsystemB subsystemB;
    private readonly SubsystemC subsystemC;

    public Facade(SubsystemA subsystemA, SubsystemB subsystemB, SubsystemC subsystemC)
    {
        this.subsystemA = subsystemA;
        this.subsystemB = subsystemB;
        this.subsystemC = subsystemC;
    }

    public void Operation1()
    {
        Console.WriteLine($"{GetType().Name} is going to perform {nameof(Operation1)}");
        subsystemA.ExecuteA1();
        subsystemB.ExecuteB1();
        subsystemC.ExecuteC1();
    }
    
    public void Operation2()
    {
        Console.WriteLine($"{GetType().Name} is going to perform {nameof(Operation2)}");
        subsystemA.ExecuteA2();
        subsystemC.ExecuteC2();
    }
}
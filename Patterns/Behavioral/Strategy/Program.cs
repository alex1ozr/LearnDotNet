// Strategy pattern

var context = new Context(new ConcreteStrategy1());

context.Execute();
context.SetStrategy(new ConcreteStrategy2());
context.Execute();


internal interface IStrategy
{
    void DoSomething();
}

internal class ConcreteStrategy1 : IStrategy
{
    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ConcreteStrategy1)} is speaking");
    }
}

internal class ConcreteStrategy2 : IStrategy
{
    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ConcreteStrategy2)} is speaking");
    }
}

internal class Context
{
    private IStrategy currentStrategy;

    public Context(IStrategy strategy)
    {
        currentStrategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        currentStrategy = strategy;
    }

    public void Execute()
    {
        currentStrategy.DoSomething();
    }
}
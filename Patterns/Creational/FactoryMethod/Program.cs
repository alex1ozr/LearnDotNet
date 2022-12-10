// Factory Method
// Порождающий шаблон проектирования, предоставляющий подклассам (дочерним классам) интерфейс
// для создания экземпляров некоторого класса.
// В момент создания наследники могут определить, какой класс создавать.

var creators = new Creator[]
{
    new ConcreteCreatorA(),
    new ConcreteCreatorB(),
};

foreach (var creator in creators)
{
    var product = creator.Create();
    Console.WriteLine($"Created {product.GetType().Name}");
}

// Implementation:

internal abstract class Product
{
}

internal class ConcreteProductA : Product
{
}

internal class ConcreteProductB : Product
{
}

abstract class Creator
{
    public abstract Product Create(); // This is a factory method
}

internal class ConcreteCreatorA : Creator
{
    public override Product Create()
    {
        return new ConcreteProductA();
    }
}

internal class ConcreteCreatorB : Creator
{
    public override Product Create()
    {
        return new ConcreteProductB();
    }
}
// Prototype
// Паттерн создания объекта через клонирование другого объекта вместо создания через конструктор.

var prototype1 = new ConcretePrototype1("Proto-1");
var clonedPrototype1 = prototype1.Clone();
Console.WriteLine ($"Cloned from {clonedPrototype1 .Id}");
 
var prototype2 = new ConcretePrototype2("Proto-2");
var clonedPrototype2 = prototype2.Clone();
Console.WriteLine ($"Cloned from {clonedPrototype2 .Id}");
 
internal abstract class Prototype
{
    public string Id { get; }
    
    protected Prototype(string id)
    {
        Id = id;
        Console.Write("Base constructor is called.");
    }

    public virtual Prototype Clone() => (Prototype)MemberwiseClone();
}
 
internal class ConcretePrototype1 : Prototype
{
    public ConcretePrototype1(string id) 
        : base(id)
    {
    }
}
 
internal class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(string id) 
        : base(id)
    {
    }
}

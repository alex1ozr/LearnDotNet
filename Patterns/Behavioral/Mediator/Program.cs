// Mediator
// Поведенческий шаблон проектирования, обеспечивающий взаимодействие множества объектов,
// формируя при этом слабое зацепление и избавляя объекты от необходимости явно ссылаться друг на друга.
// Заменяет взаимодействие "все со всеми" взаимодействием "один со всеми".

var mediator = new ConcreteMediator();
var concreteColleague1 = new ConcreteColleague1(mediator);
var concreteColleague2 = new ConcreteColleague2(mediator);
        
mediator.Colleague1 = concreteColleague1;
mediator.Colleague2 = concreteColleague2;

concreteColleague1.SendMessage("I want to eat something");
concreteColleague2.SendMessage("Mee too");

internal abstract class Mediator
{
    public abstract void Send(string msg, Colleague colleague);
}

internal abstract class Colleague
{
    private Mediator mediator;

    protected Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
    
    public void SendMessage(string message)
    {
        mediator.Send(message, this);
    }
    
    public abstract void Notify(string message);
}

internal class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator)
        : base(mediator)
    { }
 
    public override void Notify(string message)
    {
        Console.WriteLine($"{nameof(ConcreteColleague1)} gets the message: {message}");
    }
}

class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator)
        : base(mediator)
    { }
 
    public override void Notify(string message)
    {
        Console.WriteLine($"{nameof(ConcreteColleague2)} gets the message: {message}");
    }
}
 
internal class ConcreteMediator : Mediator
{
    public Colleague Colleague1 { get; set; }
    public Colleague Colleague2 { get; set; }

    public override void Send(string msg, Colleague colleague)
    {
        if (Colleague1 == colleague)
        {
            Colleague2.Notify(msg);
        }
        else if (Colleague2 == colleague)
        {
            Colleague1.Notify(msg);
        }
    }
}
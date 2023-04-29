
//A a = new A("testA");
//a.WriteToConsole();

object b = (A)new B("testB");
var c = new C("testC");

c.Execute();

"sdfsdfs".WriteLineExtended();

static class ClassCExtensions
{
    public static void Execute(this C source)
        => Console.WriteLine($"Executing for {source.Value}");

    public static void WriteLineExtended(this string source)
        => Console.WriteLine($"{source}++");
}

sealed class C: B
{
    public C(string value) : base(value)
    {
        //...
    }

    public override void WriteToConsole()
    {
        /////
        Console.WriteLine("tetetstst");
        base.WriteToConsole();
    }

    public sealed override void DoSomething()
    {
        Console.WriteLine("Do nothing");
    }
}

class B: A
{
    public B(string value) : base(value)
    {
    }
    
    public override void WriteToConsole()
        => Console.WriteLine($"{nameof(B)}.{nameof(Value)} = {Value}");

    public override void DoSomething() 
        => Console.WriteLine($"{nameof(B)}.{nameof(DoSomething)}");
}

internal abstract class A: IA, IAa
{
    protected A(string value)
    {
        Value = value;
    }
    
    public string? Value { get; set; }

    public virtual void WriteToConsole()
        => Console.WriteLine($"{nameof(A)}.{nameof(Value)} = {Value}");

    public abstract void DoSomething();
}

interface IA
{
    void WriteToConsole();

    void DoSomethingElse() => Console.WriteLine("DoSomethingElse");
}

interface IAa
{
    void WriteToConsole();
    
    void DoSomethingElse() => Console.WriteLine("DoSomethingElse");
}
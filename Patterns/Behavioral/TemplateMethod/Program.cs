// Template Method

Animal animal = new Human();
animal.Live();

animal = new Monkey();
animal.Live();


internal abstract class Animal
{
    protected abstract void Born();

    protected abstract void Work();

    protected abstract void Die();

    public void Live() // this is an Template method
    {
        Born();
        Work();
        Die();
    }
}

internal class Human : Animal
{
    protected override void Born()
    {
        Console.WriteLine($"{nameof(Human)} was born");
    }

    protected override void Work()
    {
        Console.WriteLine($"{nameof(Human)} started to work");
    }

    protected override void Die()
    {
        Console.WriteLine($"{nameof(Human)} finished their life");
    }
}

internal class Monkey : Animal
{
    protected override void Born()
    {
        Console.WriteLine($"{nameof(Monkey)} was born");
    }

    protected override void Work()
    {
        Console.WriteLine($"{nameof(Monkey)} doesn't need to work");
    }

    protected override void Die()
    {
        Console.WriteLine($"{nameof(Monkey)} finished their life");
    }
}
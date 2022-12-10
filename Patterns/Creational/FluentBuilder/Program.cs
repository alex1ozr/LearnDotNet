// FluentBuilder
// Упрощает процесс создания объектов с помощью вызовов методов-цепочек,
// которые измменяют характеристики объекта.
// Делает код более понятным и не перегруженным. Пример - StringBuilder.

var builder = new HumanBuilder();
var human = builder
    .SetName("Abraham")
    .SetAge(45)
    .SetFavoriteFood("pizza")
    .Build();

Console.WriteLine(human);

public sealed class Human
{
    public int Age { get; set; }
    
    public string? Name { get; set; }
    
    public string? FavoriteFood { get; set; }

    public override string ToString()
        => $"{Name}, age: {Age}, favorite food: {FavoriteFood}";
}

public sealed class HumanBuilder
{
    private readonly Human human;
    
    public HumanBuilder()
    {
        human = new Human();
    }
    
    public HumanBuilder SetAge(int age)
    {
        human.Age = age > 0 ? age : 0;
        return this;
    }
    
    public HumanBuilder SetName(string name)
    {
        human.Name = name;
        return this;
    }

    public HumanBuilder SetFavoriteFood(string food)
    {
        human.FavoriteFood = food;
        return this;
    }
    
    public Human Build()
    {
        return human;
    }
}


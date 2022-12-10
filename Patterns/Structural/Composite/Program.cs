// Composite (Компоновщик)
// Структурный шаблон проектирования, объединяющий объекты в древовидную структуру для представления иерархии
// от частного к целому.
// Компоновщик позволяет клиентам обращаться к отдельным объектам и к группам объектов одинаково.

var baseDir = new Directory("Games");
baseDir.PrintContent();

var mooDir = new Directory("Master of Orion II");
baseDir.Add(mooDir);
mooDir.Add(new File("Orion95.exe"));
mooDir.Add(new File("game.data"));
baseDir.PrintContent();

internal abstract class Component
{
    protected readonly string Name;

    protected Component(string name)
    {
        Name = name;
    }

    public virtual void Add(Component component)
    {
    }

    public virtual void Remove(Component component)
    {
    }

    public virtual void PrintContent()
    {
        Console.WriteLine(Name);
    }
}

internal class File : Component
{
    public File(string name)
        : base(name)
    {
    }
}

internal class Directory :Component
{
    private readonly List<Component> content = new();
 
    public Directory(string name)
        : base(name)
    {
    }
 
    public override void Add(Component component) => content.Add(component);

    public override void Remove(Component component) => content.Remove(component);

    public override void PrintContent()
    {
        Console.WriteLine($"Directory '{Name}' contains:");
        foreach (var component in content)
        {
            component.PrintContent();
        }
        Console.WriteLine($"End of dir '{Name}'");
    }
}
 

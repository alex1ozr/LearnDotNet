// Visitor

var university = new University();
var visitor1 = new Teacher("Agnes");
university.PerformOperation(visitor1);

var visitor2 = new Parent("Paul");
university.PerformOperation(visitor2);

internal interface IElement
{
    string Name { get; }
    
    void Accept(IVisitor visitor);
}

internal interface IVisitor
{
    void Visit(IElement element);
}

internal class Student : IElement
{
    public string Name { get; }
        
    public Student(string name)
    {
        Name = name;
    }
        
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

internal class Teacher : IVisitor
{
    public string Name { get; }
    
    public Teacher(string name)
    {
        Name = name;
    }
        
    public void Visit(IElement element)
    {
        Console.WriteLine($"Teacher {Name} gave a lot of homework to {element.Name}");
    }
}

internal class Parent : IVisitor
{
    private string Name { get; }

    public Parent(string name)
    {
        Name = name;
    }

    public void Visit(IElement element)
    {
        Console.WriteLine($"Parent {Name} visited his beloved child {element.Name}");
    }
}

internal class University
{
    private static List<IElement> students;

    static University()
    {
        students = new List<IElement>
        {
            new Student("Mike"),
            new Student("Boris"),
            new Student("Anna")
        };
    }

    public void PerformOperation(IVisitor visitor)
    {
        foreach (var student in students)
        {
            student.Accept(visitor);
        }
    }
}
namespace Samples.Exercises;

/// <summary>
/// Struct as property problem.
/// </summary>
/// <remarks>Hint: https://stackoverflow.com/questions/18292087/accessing-and-changing-structs-as-property-vs-as-field</remarks>
internal static class Exercise8
{
    // A: CTE
    // B: RTE
    // C: 5
    // D: 0
    public static void Execute()
    {
        var bar = new Bar { Foo = new Foo() };
        bar.Foo.SetValue(5);

        var foo = new Foo();
        foo.SetValue(20);
        
        Console.WriteLine(bar.Foo.Value);
    }
    
    public struct Foo
    {
        public int Value;
        
        public void SetValue(int newValue)
        {
            Value = newValue;
        }
    }
    
    public class Bar
    {
        public Foo Foo { get; set; }
    }
}
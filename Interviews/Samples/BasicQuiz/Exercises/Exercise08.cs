namespace Samples.Exercises;

/// <remarks>Hint: https://stackoverflow.com/questions/18292087/accessing-and-changing-structs-as-property-vs-as-field</remarks>
internal static class Exercise08
{
    // A: CTE
    // B: RTE
    // C: 1
    // D: 0
    public static void Execute()
    {
        var bar = new SomeClass { SomeStruct = new SomeStruct() };
        bar.SomeStruct.SetValue(1);

        Console.WriteLine(bar.SomeStruct.Value);
    }
    
    public struct SomeStruct
    {
        public int Value;
        
        public void SetValue(int newValue)
        {
            Value = newValue;
        }
    }
    
    public class SomeClass
    {
        public SomeStruct SomeStruct { get; set; }
    }
}
namespace Samples.Exercises;

internal static class Exercise1
{
    // A: CTE
    // B: RTE
    // C: int
    // D: long
    // E: Int32
    // F: Int64
    public static void Execute()
    {
        int a = 5;
        object o = a;
        var x = (long)o;
        Console.WriteLine(x.GetType().Name);
    }
}
namespace Samples.Exercises;

/// <remarks>\nSource from: https://andreyakinshin.gitbook.io/problembookdotnet/ru/linq/queryafterremove-p</remarks>
internal static class Exercise10
{
    // A: CTE
    // B: RTE
    // C: 0
    // D: 1
    // E: 2
    public static void Execute()
    {
        var list = new List<string> { "Foo", "Bar", "Baz" };
        var query = list.Where(c => c.StartsWith("B"));
        list.Remove("Bar");
        Console.WriteLine(query.Count());
    }
}
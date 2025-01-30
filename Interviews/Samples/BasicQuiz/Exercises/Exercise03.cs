namespace Samples.Exercises;

internal static class Exercise03
{
    // A: CTE
    // B: RTE
    // C: 0
    // D: 49
    // E: 50
    // F: 100
    public static void Execute()
    {
        var count = 0;
        Enumerable.Repeat(1, 100)
            .Where(_ => count < 50)
            .Select(x => count++);
        Console.WriteLine(count);
    }
}
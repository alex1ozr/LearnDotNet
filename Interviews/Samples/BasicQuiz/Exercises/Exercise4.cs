namespace Samples.Exercises;

internal static class Exercise4
{
    // A: CTE
    // B: RTE
    // C: True, False
    // D: False, True
    // E: False, False
    // F: True, True
    public static void Execute()
    {
        const int iterations = 1000;
        var count = 0;
        Parallel.For(0, iterations, (_) => count++);
        Console.WriteLine($"{count}, {count > iterations}, {count < iterations}");
    }
}
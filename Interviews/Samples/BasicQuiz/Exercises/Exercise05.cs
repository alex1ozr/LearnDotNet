namespace Samples.Exercises;

internal static class Exercise05
{
    // A: CTE
    // B: RTE
    // C: 00000
    // D: 0 1 2 3 4
    // E: 1 2 3 4 5
    // F: 5 5 5 5 5
    // See also: http://sergeyteplyakov.blogspot.com/2012/04/c-50.html
    public static void Execute()
    {
        var actions = new List<Action>();
        for (var count = 0; count < 5; count++)
        {
            actions.Add(() => Console.Write(count + " "));
        }

        foreach (var action in actions)
        {
            action();
        }

        Console.WriteLine();
    }
}
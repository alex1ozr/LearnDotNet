namespace Samples.Exercises;

internal static class Exercise02
{
    // A: CTE
    // B: RTE
    // C: 123
    // D: 345
    // E: 123345
    // F:
    public static void Execute()
    {
        var str = "123";
        var newStr = str;
        str = newStr + "345";
        Console.WriteLine(newStr);
    }
}
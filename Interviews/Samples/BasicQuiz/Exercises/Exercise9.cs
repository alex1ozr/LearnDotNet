namespace Samples.Exercises;

/// <remarks>Hint: https://stackoverflow.com/questions/32385930/when-can-a-listt-have-its-enumerator-current-always-return-null</remarks>
/// <remarks>\nSource from: https://andreyakinshin.gitbook.io/problembookdotnet/en/valuetypes/enumerator-p</remarks>
internal static class Exercise9
{
    // A: CTE
    // B: RTE
    // C: 0
    // D: 0,0,0,0,...
    // E: 1,2,3
    public static void Execute()
    {
        var x = new 
        {
            Items = new List<int> { 1, 2, 3 }.GetEnumerator()
        };
        while (x.Items.MoveNext())
        {
            Console.WriteLine(x.Items.Current);
        }
    }
}
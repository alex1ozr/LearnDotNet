namespace Samples.Exercises;

/// <summary>
/// <see cref="List{T}.GetEnumerator()"/> problem.
/// </summary>
/// <remarks>Hint: https://stackoverflow.com/questions/32385930/when-can-a-listt-have-its-enumerator-current-always-return-null</remarks>
internal static class Exercise9
{
    // A: CTE
    // B: RTE
    // C: 0
    // D: 0,0,0,0,...
    // D: 1,2,3
    public static void Execute()
    {
        var obj = new 
        {
            Items = new List<int> { 1, 2, 3 }.GetEnumerator()
        };
        
        while (obj.Items.MoveNext())
        {
            Console.WriteLine(obj.Items.Current);
        }
    }
}
namespace Samples.Exercises;

internal static class Exercise6
{
    // A: CTE
    // B: RTE - line 20
    // C: RTE - not line 20
    // D: 10, 7
    // E: 10, 8
    // F: 7, 8
    // E: 8, 7
    // G: 8, 8
    // H: 7, 7
    public static void Execute()
    {
        object x = 10;
        var myStruct = new MyStruct
        {
            X = 7
        };

        Do(ref x, myStruct);
        Console.WriteLine($"{x}, {myStruct}");
    }
    
    private struct MyStruct
    {
        public int X;
        public override string ToString() => X.ToString();
    }

    private static void Do(ref object o, MyStruct myStruct)
    {
        o = myStruct;
        myStruct.X++;
    }
}
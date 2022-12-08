namespace Samples.Exercises;

internal static class Exercise7
{
    // A: CTE
    // B: RTE
    // C: IP IC
    // D: IC IP
    // E: SP IP SC IC
    // F: SP SC IP IC
    // G: SC SP IC IP
    // H: IP IC SP SC
    public static void Execute()
    {
        new MyClass();
    }

    private class MyClass
    {
        private static string PrintAndReturn(string text)
        {
            Console.Write(text);
            return text;
        }

        public static string StaticProperty { get; } = PrintAndReturn("SP ");
        public string InstanceProperty { get; } = PrintAndReturn("IP ");

        public MyClass() => PrintAndReturn("IC ");
        static MyClass() => PrintAndReturn("SC ");
    }
}
namespace Samples.Exercises;

internal static class Exercise11
{
    struct Struct1
    {
        public int A;
    }

    class Class1
    {
        public int A;
    }

    public static void Execute()
    {
        // What array takes more memory?
        var arr1 = new Struct1[10];
        var arr2 = new Class1[10];
    }
}
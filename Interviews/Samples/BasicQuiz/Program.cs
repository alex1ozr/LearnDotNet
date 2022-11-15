using Samples;

Helpers.AsTryCatch(Exercise1);
Helpers.AsTryCatch(Exercise2);
Helpers.AsTryCatch(Exercise3);
Helpers.AsTryCatch(Exercise4);
Helpers.AsTryCatch(Exercise5);
Helpers.AsTryCatch(Exercise6.Run);
Helpers.AsTryCatch(Exercise7.Run);

// A: CTE
// B: RTE
// C: int
// D: long
// E: Int32
// F: Int64
static void Exercise1()
{
    int a = 5;
    object o = a;
    var x = (long)o;
    Console.WriteLine("Exercise 1: "+ x.GetType().Name);
}

// A: CTE
// B: RTE
// C: 123
// D: 345
// E: 123345
// F:
static void Exercise2()
{
    var str = "123";
    var newStr = str;
    str = newStr + "345";
    Console.WriteLine("Exercise 2: "+ newStr);
}

// A: CTE
// B: RTE
// C: 0
// D: 49
// E: 50
// F: 100
static void Exercise3()
{
    var count = 0;
    Enumerable.Repeat(1, 100)
        .Where((_) => count < 50)
        .Select((x) => count++);
    Console.WriteLine("Exercise 3: " + count);
}

// A: CTE
// B: RTE
// C: True, False
// D: False, True
// E: False, False
// F: True, True
static void Exercise4()
{
    const int iterations = 1000;
    var count = 0;
    Parallel.For(0, iterations, (_) => count++);
    Console.WriteLine($"Exercise 4: {count}, {count > iterations}, {count < iterations}");
}

// A: CTE
// B: RTE
// C: 00000
// D: 0 1 2 3 4
// E: 1 2 3 4 5
// F: 5 5 5 5 5
// See also: http://sergeyteplyakov.blogspot.com/2012/04/c-50.html
static void Exercise5()
{
    Console.WriteLine("Exercise 5:");
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

// A: CTE
// B: RTE - line 20
// C: RTE - not line 20
// D: 10, 7
// E: 10, 8
// F: 7, 8
// E: 8, 7
// G: 8, 8
// H: 7, 7
internal static class Exercise6
{
    public static void Run()
    {
        Console.WriteLine("Exercise 6:");
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

// A: CTE
// B: RTE
// C: IP IC
// D: IC IP
// E: SP IP SC IC
// F: SP SC IP IC
// G: SC SP IC IP
// H: IP IC SP SC
internal static class Exercise7
{
    public static void Run()
    {
        Console.WriteLine("Exercise 7: ");
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

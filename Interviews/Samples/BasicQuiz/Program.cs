using System.Reflection;
using Samples.Helpers;

Console.WriteLine("Enter the exercise number and press ENTER: ");
var input = ConsoleExt.ReadLineOrEsc();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No exercise was selected");
    return;
}

if (input.Length == 1)
{
    input = "0" + input;
}

const string classTemplate = "Exercise";
const string methodName = "Execute";
var exercises = typeof(Program)
    .Assembly
    .GetTypes()
    .Where(x => x.Name.StartsWith(classTemplate))
    .ToDictionary(x => x.Name.Replace(classTemplate, ""));

if (!exercises.TryGetValue(input, out var exerciseType))
{
    Console.WriteLine("Wrong exercise number was entered");
    return;
}

Console.WriteLine($"Executing {exerciseType.Name}:");

var sourceFilePath = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory,
    $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Exercises{Path.DirectorySeparatorChar}{exerciseType.Name}.cs"
);

if (File.Exists(sourceFilePath))
{
    var sourceCode = File.ReadAllText(sourceFilePath);
    Console.WriteLine(sourceCode);
    
    Console.WriteLine("What do you think the output will be?");
    Console.ReadKey();
}

exerciseType.GetMethod(methodName)?.Invoke(null, null);

Console.ReadKey();













using Samples.Helpers;

Console.WriteLine("Enter the exercise number and press ENTER: ");
var input = ConsoleExt.ReadLineOrEsc();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No exercise was selected");
    return;
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
exerciseType.GetMethod(methodName).Invoke(null, null);

Console.ReadKey();













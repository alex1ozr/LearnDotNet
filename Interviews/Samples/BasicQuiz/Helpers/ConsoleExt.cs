using System.Text;

namespace Samples.Helpers;

internal static class ConsoleExt
{
    public static string? ReadLineOrEsc()
    {
        var resultStr = new StringBuilder();

        var curIndex = 0;
        do
        {
            var readKeyResult = Console.ReadKey(true);

            switch (readKeyResult.Key)
            {
                case ConsoleKey.Escape:
                    Console.WriteLine();
                    return null;
                case ConsoleKey.Enter:
                    Console.WriteLine();
                    return resultStr.ToString();
                case ConsoleKey.Backspace:
                {
                    if (curIndex > 0)
                    {
                        resultStr = resultStr.Remove(resultStr.Length - 1, 1);
                        Console.Write("\b \b");
                        curIndex--;
                    }

                    break;
                }
                default:
                    resultStr.Append(readKeyResult.KeyChar);
                    Console.Write(readKeyResult.KeyChar);
                    curIndex++;
                    break;
            }
        } while (true);
    }
}
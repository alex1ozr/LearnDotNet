namespace Samples;

internal static class Helpers
{
    public static void AsTryCatch(this Action action)
    {
        try
        {
            action();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
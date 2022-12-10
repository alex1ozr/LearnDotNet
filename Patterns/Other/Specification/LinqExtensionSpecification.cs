namespace LearnDotNet.Specification;

internal static class LinqExtensionSpecification
{
    public static IEnumerable<int> GreaterThan10(this IEnumerable<int> source)
        => source.Where(x => x > 10);
    
    public static IEnumerable<int> LessThan100(this IEnumerable<int> source)
        => source.Where(x => x < 100);
}
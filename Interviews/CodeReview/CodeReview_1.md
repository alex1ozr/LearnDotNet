Do code review, optimize and say O(n):

```cs
public static class MyLinq
{
    public static IEnumerable<T> Reverse<T>(this IEnumerable<T> source)
    {
        var result = new List<T>();
        foreach (var item in source)
        {
            result.Insert(0, item);
        }
 
        return result;
    }
 
 
    public static IEnumerable<T> Except<T>(this IEnumerable<T> source, T[] except)
    {
        foreach (var item in source)
        {
            if (Array.FindIndex(except, i => item.Equals(i)) != -1)
                continue;
 
            yield return item;
        }
    }
 
 
    public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source)
    {
        var result = new List<T>();
 
        foreach (var item in source)
        {
            var contains = false;
            foreach (var e in result)
            {
                if (e.Equals(item))
                {
                    contains = true;
                    break;
                }
            }
 
            if (!contains)
                result.Add(item);
        }
 
        return result;
    }
}
```
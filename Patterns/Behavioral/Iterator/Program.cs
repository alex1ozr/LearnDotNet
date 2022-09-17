using System.Collections;

// Iterator
var iterator = new StringIterator("str1", "str2", "str3");
foreach (var item in iterator)
{
    Console.WriteLine(item);
}

internal class StringIterator
{
    private readonly string[] values;

    public StringIterator(params string[] values)
    {
        this.values = values;
    }

    public IEnumerator<string> GetEnumerator() => new StringEnumerator(values);
}

internal class StringEnumerator: IEnumerator<string>
{
    private readonly string[] items;
    private int currentIndex = -1;
    
    public StringEnumerator(params string[] items)
    {
        this.items = items;
    }

    public bool MoveNext()
    {
        if (items.Length != 0 && items.Length - 1 > currentIndex)
        {
            currentIndex++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        currentIndex = 0;
    }

    public string Current => items.ElementAt(currentIndex);

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
}
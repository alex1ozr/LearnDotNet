namespace Samples.Exercises;

// Is there a bug in this code? If so, what is it?
/*
internal static class Exercise12
{
    const string PREFFIX = "_";

    void Execute()
    {
        var collection = new List<string>();
        //fill collection
        PrepareData(ref collection);
        foreach (var item in collection)
        {
            if (item.StartsWith(PREFFIX))
            {
                collection.Remove(item); // <--- changing the collection while iterating
            }
        }
    }

    private abstract void PrepareData(ICollection<string> collection);
}
*/
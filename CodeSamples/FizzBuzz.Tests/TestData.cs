namespace FizzBuzz.Tests;

public static class TestData
{
    public static IEnumerable<object[]> GetFizzBuzzTestData()
    {
        yield return new object[] { 15, "FizzBuzz" };
        yield return new object[] { 5, "Buzz" };
        yield return new object[] { 3, "Fizz" };
        yield return new object[] { 1, "1" };
    }
}
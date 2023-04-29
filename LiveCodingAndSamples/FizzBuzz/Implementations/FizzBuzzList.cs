namespace LearnDotNet.FizzBuzz.Implementations;

public class FizzBuzzList: IFizzBuzz
{
    public IEnumerable<string> ConvertToFizzBuzz(IEnumerable<int> input)
    {
        var result = new List<string>();

        foreach (var num in input)
        {
            result.Add(num % 15 == 0
                ? "FizzBuzz"
                : num % 5 == 0
                    ? "Buzz"
                    : num % 3 == 0
                        ? "Fizz"
                        : num.ToString());
        }

        return result;
    }
}
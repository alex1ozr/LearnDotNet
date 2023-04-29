namespace LearnDotNet.FizzBuzz.Implementations;

public class FizzBuzzLinq: IFizzBuzz
{
    public IEnumerable<string> ConvertToFizzBuzz(IEnumerable<int> input)
    {
        return input.Select(x => x % 15 == 0
            ? "FizzBuzz"
            : x % 5 == 0
                ? "Buzz"
                : x % 3 == 0
                    ? "Fizz"
                    : x.ToString());
    }
}
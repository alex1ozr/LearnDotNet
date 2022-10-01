namespace LearnDotNet.FizzBuzz.Implementations;

public class FizzBuzzYield : IFizzBuzz
{
    public IEnumerable<string> ConvertToFizzBuzz(IEnumerable<int> input)
    {
        foreach (var num in input)
        {
            if (num % 15 == 0)
            {
                yield return "FizzBuzz";
            }
            else if (num % 5 == 0)
            {
                yield return "Buzz";
            }
            else if (num % 3 == 0)
            {
                yield return "Fizz";
            }
            else
            {
                yield return num.ToString();
            }
        }
    }
}
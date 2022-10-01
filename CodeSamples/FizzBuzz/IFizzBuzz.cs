namespace LearnDotNet.FizzBuzz;

public interface IFizzBuzz
{
    IEnumerable<string> ConvertToFizzBuzz(IEnumerable<int> input);
}
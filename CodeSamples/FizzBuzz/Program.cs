using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;
using LearnDotNet.FizzBuzz;
using LearnDotNet.FizzBuzz.Implementations;

BenchmarkRunner.Run<FizzBuzzBenchmark>();

namespace LearnDotNet.FizzBuzz
{
    [MemoryDiagnoser(displayGenColumns:false)]
    public class FizzBuzzBenchmark
    {
        private static readonly Random random = new();
        private int[] data = Array.Empty<int>();

        private readonly Consumer consumer = new();
        private readonly FizzBuzzLinq fizzBuzzLinq = new();
        private readonly FizzBuzzList fizzBuzzList = new();
        private readonly FizzBuzzYield fizzBuzzYield = new();

        [GlobalSetup]
        public void Setup()
        {
            data = Enumerable.Repeat(15, 10_000_000).ToArray();
            //data = Enumerable.Repeat(15, 10_000).Select(_ => random.Next()).ToArray();
        }
    
        [Benchmark]
        public void FizzBuzzLinq() => fizzBuzzLinq.ConvertToFizzBuzz(data).Consume(consumer);
    
        [Benchmark]
        public void FizzBuzzList() => fizzBuzzList.ConvertToFizzBuzz(data).Consume(consumer);
    
        [Benchmark]
        public void FizzBuzzYield() => fizzBuzzYield.ConvertToFizzBuzz(data).Consume(consumer);
    }
}
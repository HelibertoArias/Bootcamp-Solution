using BenchmarkDotNet.Attributes;
using System.Text;

using static System.Console;

namespace BenchmarkConsoleApp;

public class StringBenchmarks
{
    public int[] numbers { get; }

    public StringBenchmarks()
    {
        numbers = Enumerable.Range(start: 1, count: 10).ToArray();
    }


    [Benchmark(Baseline = true)]
    public string StringConcatenation()
    {
        string s = string.Empty; // i.e. "";

        for (int i = 0; i < numbers.Length; i++)
        {
            s += numbers[i] + ", ";
        }

        return s;
    }



    [Benchmark]
    public string StringbuilderConcatenation()
    {
         

        StringBuilder builder = new();

        for (int i = 0; i < numbers.Length; i++)
        {
            builder.Append(numbers[i]);
            builder.Append(", ");
        }

        return builder.ToString();
    }
}



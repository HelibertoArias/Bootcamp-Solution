/*
    Steps
- Install the Nuget package BenchmarkDotNet
- add "using BenchmarkDotNet.Running into your class
- Add attributes [Benchmark(Baseline = true)] or [Benchmark()] to the methods to compare in a class.
- Run your code BenchmarkRunner.Run<YourClass>();
- Set your build as Release
- More info https://github.com/dotnet/BenchmarkDotNet
 */
using BenchmarkConsoleApp;
using BenchmarkDotNet.Running;
//Console.WriteLine("Benchmark.Net");

//BenchmarkRunner.Run<StringBenchmarks>();



//var item = new MedianCalculator();
SearchFind.Run();
Console.ReadLine();


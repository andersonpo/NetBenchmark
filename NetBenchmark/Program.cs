using BenchmarkDotNet.Running;
using System;

namespace NetBenchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INICIANDO BENCHMARKS!");

            BenchmarkRunner.Run<ConcatenacaoDeStrings>();
            BenchmarkRunner.Run<ComparacaoDeString>();

            Console.WriteLine("FIM BENCHMARKS!");
        }
    }
}
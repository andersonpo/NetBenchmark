
using BenchmarkDotNet.Attributes;
using System;

namespace NetBenchmark
{
    [Config(typeof(ConfiguracaoDoBenchmark))]
    public class ComparacaoDeString
    {

        private const string texto1 = "TESTE COMPARANDO STRING";
        private const string texto2 = "Teste comparando string";

        [Benchmark(Baseline = true)]
        public bool EqualsOrdinalIgnoraCase() => string.Equals(texto1, texto2, StringComparison.OrdinalIgnoreCase);

        [Benchmark]
        public bool CompareOrdinalIgnoraCase() => string.Compare(texto1, texto2, StringComparison.OrdinalIgnoreCase) == 0;

        [Benchmark]
        public bool IgualMinusculo() => texto1.ToLower() == texto2.ToLower();

        [Benchmark]
        public bool IgualMaiusculo() => texto1.ToUpper() == texto2.ToUpper();


        [Benchmark]
        public bool IgualMinusculoInvariante() => texto1.ToLowerInvariant() == texto2.ToLowerInvariant();

        [Benchmark]
        public bool IgualMaiusculoInvariante() => texto1.ToUpperInvariant() == texto2.ToUpperInvariant();

    }
}
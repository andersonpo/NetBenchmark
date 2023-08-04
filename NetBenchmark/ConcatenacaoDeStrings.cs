using BenchmarkDotNet.Attributes;
using System.Text;

namespace NetBenchmark
{
    [Config(typeof(ConfiguracaoDoBenchmark))]
    public class ConcatenacaoDeStrings
    {

        const string primeiroValor = "Anderson";
        const string segundoValor = "Pereira";
        const string terceiroValor = "Oliveira";

        [Benchmark]
        public string ConcatenacaoComMais()
        {
            return primeiroValor + " " + segundoValor + " " + terceiroValor;
        }

        [Benchmark]
        public string ConcatenacaoComFormat()
        {
            return string.Format("{0} {1} {2}", primeiroValor, segundoValor, terceiroValor);
        }

        [Benchmark(Baseline = true)]
        public string ConcatenacaoComInterpolacao()
        {
            return $"{primeiroValor} {segundoValor} {terceiroValor}";
        }

        [Benchmark]
        public string ConcatenacaoComJoin()
        {
            return string.Join(" ", primeiroValor, segundoValor, terceiroValor);
        }

        [Benchmark]
        public string ConcatenacaoComStringBuilderAppend()
        {
            var texto = new StringBuilder();
            return texto
                .Append(primeiroValor).Append(' ')
                .Append(segundoValor).Append(' ')
                .Append(terceiroValor).ToString();
        }

        [Benchmark]
        public string ConcatenacaoComStringBuilderAppendExato()
        {
            var texto = new StringBuilder(25);
            return texto
                .Append(primeiroValor).Append(' ')
                .Append(segundoValor).Append(' ')
                .Append(terceiroValor).ToString();
        }

        [Benchmark]
        public string ConcatenacaoComStringBuilderAppendEstimado()
        {
            var texto = new StringBuilder(50);
            return texto
                .Append(primeiroValor).Append(' ')
                .Append(segundoValor).Append(' ')
                .Append(terceiroValor).ToString();
        }

        [Benchmark]
        public string ConcatenacaoComStringBuilderFormat()
        {
            var texto = new StringBuilder();
            return texto.AppendFormat("{0} {1} {2}", primeiroValor, segundoValor, terceiroValor).ToString();
        }

#if NET6_0_OR_GREATER

        [Benchmark]
        public string ConcatenacaoComStringBuilderJoin()
        {
            var texto = new StringBuilder();
            return texto.AppendJoin(" ", primeiroValor, segundoValor, terceiroValor).ToString();
        }

#endif

    }
}
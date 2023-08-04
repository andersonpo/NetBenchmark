using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using System.IO;
using System.Reflection;

namespace NetBenchmark
{
    public class ConfiguracaoDoBenchmark : ManualConfig
    {
        public ConfiguracaoDoBenchmark()
        {
            //ArtifactsPath = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
            
            WithSummaryStyle(SummaryStyle.Default.WithRatioStyle(RatioStyle.Percentage));

            //AddExporter(CsvMeasurementsExporter.Default);
            AddExporter(RPlotExporter.Default);
            AddExporter(HtmlExporter.Default);

            AddDiagnoser(MemoryDiagnoser.Default);

            WithOptions(ConfigOptions.JoinSummary);
            WithOptions(ConfigOptions.DisableLogFile);

            HideColumns(Column.Job);
            HideColumns(Column.RatioSD);
            HideColumns(Column.AllocRatio);

            AddJob(
                Job.Default
                .WithPlatform(Platform.X64)
                .WithRuntime(ClrRuntime.Net472)
                .WithId("Net-4.7.2-x64"));

            AddJob(
                Job.Default
                .WithPlatform(Platform.X64)
                .WithRuntime(CoreRuntime.Core60)
                .WithBaseline(true)
                .WithId("Net-6.0-x64"));

            AddJob(
                Job.Default
                .WithPlatform(Platform.X64)
                .WithRuntime(CoreRuntime.Core80)
                .WithId("Net-8.0-x64"));

            WithOrderer(new DefaultOrderer(SummaryOrderPolicy.Method, MethodOrderPolicy.Alphabetical));
            //WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Alphabetical));
        }
    }
}
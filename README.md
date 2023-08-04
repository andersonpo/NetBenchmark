# NetBenchmark
Testes de benchmarks com .Net

Acessar o diretorio onde está o CSPROJ e executar na linha de comando
```
dotnet run -c Release --framework net6.0
```

Após execução irá criar um diretório `BenchmarkDotNet.Artifacts/results`
dentro dele terá 1 arquivo html para cada classe executada em benchmark e as imagens dos gráficos

OBS: Para gerar as imagens de gráficos é necessário instalar o R e configurar no PATH a variavel R_HOME
<br> R_HOME apontando para /path/to/R/R-1.2.3/, e não para o diretório bin /path/to/R/R-1.2.3/bin
<br> https://benchmarkdotnet.org/articles/configs/exporters.html#plots
<br> https://www.r-project.org/


Mais detalhes em do Benchmark
<br> https://benchmarkdotnet.org/
<br> https://github.com/dotnet/BenchmarkDotNet

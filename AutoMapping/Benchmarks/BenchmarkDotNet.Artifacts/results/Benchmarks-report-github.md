``` ini

BenchmarkDotNet=v0.10.4, OS=Windows 10.0.14393
Processor=Intel Core i7-6700HQ CPU 2.60GHz (Skylake), ProcessorCount=8
Frequency=2531249 Hz, Resolution=395.0619 ns, Timer=TSC
dotnet cli version=1.0.3
  [Host]     : .NET Core 4.6.25009.03, 64bit RyuJIT [AttachedDebugger]
  DefaultJob : .NET Core 4.6.25009.03, 64bit RyuJIT


```
 |            Method |        Mean |     Error |    StdDev |
 |------------------ |------------:|----------:|----------:|
 | MapWithAutoMapper | 164.7231 ns | 3.5887 ns | 7.5699 ns |
 |       MapManually |   8.8151 ns | 0.2767 ns | 0.5462 ns |

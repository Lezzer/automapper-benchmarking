``` ini

BenchmarkDotNet=v0.10.4, OS=Windows 10.0.14393
Processor=Intel Core i7-6700HQ CPU 2.60GHz (Skylake), ProcessorCount=8
Frequency=2531251 Hz, Resolution=395.0616 ns, Timer=TSC
dotnet cli version=1.0.3
  [Host]     : .NET Core 4.6.25009.03, 64bit RyuJIT [AttachedDebugger]
  DefaultJob : .NET Core 4.6.25009.03, 64bit RyuJIT


```
 |            Method |        Mean |     Error |    StdDev |
 |------------------ |------------:|----------:|----------:|
 | MapWithAutoMapper | 158.5810 ns | 3.3479 ns | 6.6085 ns |
 |       MapManually |   9.4429 ns | 0.2851 ns | 0.5561 ns |

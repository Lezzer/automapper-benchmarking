``` ini

BenchmarkDotNet=v0.10.5, OS=Windows 10.0.14393
Processor=Intel Core i7-6700HQ CPU 2.60GHz (Skylake), ProcessorCount=8
Frequency=2531253 Hz, Resolution=395.0613 ns, Timer=TSC
dotnet cli version=1.0.3
  [Host]     : .NET Core 4.6.25009.03, 64bit RyuJIT [AttachedDebugger]
  DefaultJob : .NET Core 4.6.25009.03, 64bit RyuJIT


```
 |            Method |      Mean |    Error |    StdDev |
 |------------------ |----------:|---------:|----------:|
 | MapWithAutoMapper | 156.69 ns | 2.381 ns | 2.2275 ns |
 |       MapManually |  10.54 ns | 1.016 ns | 0.9982 ns |

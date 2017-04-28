using BenchmarkDotNet.Attributes;
using Benchmarks.AutoMapper;

namespace Benchmarks.SimpleObjects
{
    public class Benchmarks
    {
        private readonly SourceObject _source;

        public Benchmarks()
        {
            _source = new SourceObject
            {
                Id = 123,
                Description = "This is the Source object",
                UnusualMapping = "This is the value of UnusualMapping"
            };

            AutoMappingConfigurator.Configure();
        }

        [Benchmark]
        public DestinationObject MapWithAutoMapper() => Mappers.MapWithAutoMapper(_source);

        [Benchmark]
        public DestinationObject MapManually() => Mappers.MapManually(_source);
    }

}
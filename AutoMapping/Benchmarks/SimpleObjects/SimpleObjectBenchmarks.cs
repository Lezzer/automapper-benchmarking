using AutoMapper;
using BenchmarkDotNet.Attributes;
using Benchmarks.AutoMapper;

namespace Benchmarks.SimpleObjects
{
    public class SimpleObjectBenchmarks
    {
        private readonly SourceObject _source;

        public SimpleObjectBenchmarks()
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
        public DestinationObject MapWithAutoMapper()
        {
            return Mapper.Map<DestinationObject>(_source);
        }

        [Benchmark]
        public DestinationObject MapManually()
        {
            return new DestinationObject
            {
                Id = _source.Id,
                Description = _source.Description,
                MappedUnusually = _source.UnusualMapping
            };
        }
    }

}
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Benchmarks.AutoMapper;

namespace Benchmarks.ComplexObjects
{
    public class Benchmarks
    {
        private readonly SourceObject _source;

        public Benchmarks()
        {
            _source = new SourceObject
            {
                Id = 123,
                Description = "My Complex Type",
                CustomTypes = new List<SimpleCustomType>
                {
                    new SimpleCustomType
                    {
                        Id = 1,
                        Description = "The first thing..."
                    },
                    new SimpleCustomType
                    {
                        Id = 2,
                        Description = "The second thing..."
                    },
                }
            };

            AutoMappingConfigurator.Configure();
        }

        [Benchmark]
        public DestinationObject MapWithAutoMapper() => Mappers.MapWithAutoMapper(_source);

        [Benchmark]
        public DestinationObject MapManually() => Mappers.MapManually(_source);
    }
}
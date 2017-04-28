using AutoMapper;
using Benchmarks.SimpleObjects;

namespace Benchmarks.AutoMapper
{
    public static class AutoMappingConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(Config);
        }

        private static void Config(IMapperConfigurationExpression config)
        {
            config
                .CreateMap<SourceObject, DestinationObject>()
                .ForMember(d => d.MappedUnusually, d => d.MapFrom(s => s.UnusualMapping));
        }
    }
}
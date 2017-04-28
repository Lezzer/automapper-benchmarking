using System.Diagnostics.CodeAnalysis;
using AutoMapper;

namespace Benchmarks.AutoMapper
{
    [SuppressMessage("ReSharper", "MethodTooLong")]
    public static class AutoMappingConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(Config);
        }

        private static void Config(IMapperConfigurationExpression config)
        {
            AddSimpleObjectsMap(config);

            AddComplexObjectsMap(config);
        }

        private static void AddSimpleObjectsMap(IProfileExpression config)
        {
            config
                .CreateMap<SimpleObjects.SourceObject, SimpleObjects.DestinationObject>()
                .ForMember(d => d.MappedUnusually, d => d.MapFrom(s => s.UnusualMapping));
        }

        private static void AddComplexObjectsMap(IProfileExpression config)
        {
            config
                .CreateMap<ComplexObjects.SourceObject, ComplexObjects.DestinationObject>()
                .ForMember(d => d.DestinationDescription, d => d.MapFrom(s => s.Description))
                .ForMember(d => d.DestinationCustomTypes, d => d.MapFrom(s => s.CustomTypes));
        }
    }
}
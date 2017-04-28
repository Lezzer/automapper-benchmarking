using AutoMapper;

namespace Benchmarks.SimpleObjects
{
    public static class Mappers
    {
        public static DestinationObject MapWithAutoMapper(SourceObject source)
        {
            return Mapper.Map<DestinationObject>(source);
        }

        public static DestinationObject MapManually(SourceObject source)
        {
            return new DestinationObject
            {
                Id = source.Id,
                Description = source.Description,
                MappedUnusually = source.UnusualMapping
            };
        }
    }
}
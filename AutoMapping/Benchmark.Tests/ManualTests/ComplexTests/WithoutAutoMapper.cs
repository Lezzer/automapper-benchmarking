using Benchmarks.AutoMapper;
using Benchmarks.SimpleObjects;
using Xunit;

namespace Benchmarks.Tests.ManualTests.ComplexTests
{
    public class WithoutAutoMapper
    {
        internal SourceObject Source;
        internal DestinationObject Destination;

        public WithoutAutoMapper()
        {
            AutoMappingConfigurator.Configure();

            Source = new SourceObject
            {
                Id = 123,
                Description = "This is the Source object",
                UnusualMapping = "This is the value of UnusualMapping"
            };

            Destination = Mappers.MapManually(Source);
        }

        ~WithoutAutoMapper()
        {
            Source = null;
            Destination = null;
        }
        
        [Fact]
        public void FieldMappedCorrectly_Id()
        {
            Assert.Equal(Source.Id, Destination.Id);
        }

        [Fact]
        public void FieldMappedCorrectly_Description()
        {
            Assert.Equal(Source.Description, Destination.Description);
        }

        [Fact]
        public void FieldMappedCorrectly_UnusualMapping_MappedUnusually()
        {
            Assert.Equal(Source.UnusualMapping, Destination.MappedUnusually);
        }
    }
}

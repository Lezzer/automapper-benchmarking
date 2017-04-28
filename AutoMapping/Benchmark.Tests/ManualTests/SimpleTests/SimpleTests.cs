using AutoMapper;
using Benchmarks.SimpleObjects;
using Xunit;

namespace Benchmarks.Tests.ManualTests.SimpleTests
{
    public class SimpleTests
    {
        private SourceObject _source;
        private DestinationObject _destination;

        public SimpleTests()
        {
            _source = new SourceObject
            {
                Id = 123,
                Description = "This is the Source object",
                UnusualMapping = "This is the value of UnusualMapping"
            };

            _destination = Mapper.Map<DestinationObject>(_source);
        }

        ~SimpleTests()
        {
            _source = null;
            _destination = null;
        }
        
        [Fact]
        public void FieldMappedCorrectly_Id()
        {
            Assert.Equal(_source.Id, _destination.Id);
        }

        [Fact]
        public void FieldMappedCorrectly_Description()
        {
            Assert.Equal(_source.Description, _destination.Description);
        }

        [Fact]
        public void FieldMappedCorrectly_UnusualMapping_MappedUnusually()
        {
            Assert.Equal(_source.UnusualMapping, _destination.MappedUnusually);
        }
    }
}

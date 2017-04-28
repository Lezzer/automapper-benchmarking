using System.Collections.Generic;
using Benchmarks.AutoMapper;
using Benchmarks.ComplexObjects;
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
                Id = 456,
                Description = "The Source object",
                CustomTypes = new List<SimpleCustomType>()
                {
                    new SimpleCustomType
                    {
                        Id = 321,
                        Description = "A string"
                    },
                    new SimpleCustomType
                    {
                        Id = 212,
                        Description = "I was in the 212"
                    }
                }
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
            Assert.Equal(Source.Description, Destination.DestinationDescription);
        }

        [Fact]
        public void ArrayMappedCorrectly_CustomTypes_DestinationCustomTypes()
        {
            Assert.Equal(Source.CustomTypes, Destination.DestinationCustomTypes);
        }
    }
}

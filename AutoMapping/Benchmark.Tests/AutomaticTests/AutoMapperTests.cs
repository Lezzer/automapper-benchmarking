using AutoMapper;
using Benchmarks.AutoMapper;
using Xunit;

namespace Benchmarks.Tests.AutomaticTests
{
    public class AutoMapperTests
    {
        [Fact]
        public void AutoMapperConfigurationIsCorrect()
        {
            var result = true;

            try
            {
                AutoMappingConfigurator.Configure();
                Mapper.AssertConfigurationIsValid();
            }
            catch 
            {
                result = false;
            }

            Assert.True(result);
        }
    }
}

using AutoMapper;
using Benchmarks.SimpleObjects;
using Xunit;

namespace Benchmarks.Tests.AutomaticTests
{
    public class AutoMapperTests
    {
        [Fact]
        public void AutoMapperConfigurationIsCorrect()
        {
            bool result;

            try
            {
                new SimpleObjectBenchmarks();
                Mapper.AssertConfigurationIsValid();
                result = true;
            }
            catch 
            {
                result = false;
            }

            Assert.True(result);
        }
    }
}

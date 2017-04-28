using System.Collections.Generic;

namespace Benchmarks.ComplexObjects
{
    public class ComplexObjectBenchmarks
    {
        private readonly SourceObject _source;

        public ComplexObjectBenchmarks()
        {
            _source = new SourceObject
            {
                Id = 123,
                Description = "My Complex Type",
                CustomTypes = new List<SimpleCustomType>
                {

                }
            };


        }
    }
}
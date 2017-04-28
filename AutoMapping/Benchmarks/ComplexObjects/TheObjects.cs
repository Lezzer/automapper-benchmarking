using System.Collections.Generic;

namespace Benchmarks.ComplexObjects
{
    public class SimpleCustomType
    {
        public int Id { get; set; }

        public string Description { get; set; }
    }

    public class SourceObject
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<SimpleCustomType> CustomTypes { get; set; }
    }

    public class DestinationObject
    {
        public int Id { get; set; }

        public string DestinationDescription { get; set; }

        public List<SimpleCustomType> DestinationCustomTypes { get; set; }
    }
}
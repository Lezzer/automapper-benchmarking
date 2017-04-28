namespace Benchmarks.SimpleObjects
{
    public class SourceObject
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string UnusualMapping { get; set; }
    }

    public class DestinationObject
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string MappedUnusually { get; set; }
    }
}
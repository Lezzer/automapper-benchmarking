using System;
using BenchmarkDotNet.Running;
using Benchmarks.SimpleObjects;

namespace Benchmarks
{
    internal class Program
    {
        protected Program() { }

        protected static void Main(string[] args)
        {
            BenchmarkRunner.Run<SimpleObjects.Benchmarks>();
    
            Console.WriteLine("Tests Complete!");
            Console.ReadKey();
        }
    }
}
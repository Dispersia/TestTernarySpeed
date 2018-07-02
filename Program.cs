using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MyBenchmark>();

            Console.ReadKey();
        }
    }

    public class MyBenchmark
    {
        public static bool IsNullOrEmpty(string value) => (value == null || 0u >= (uint)value.Length);
        public static bool IsNullOrEmpty2(string value) => (value == null || 0u >= (uint)value.Length) ? true : false;

        [Benchmark]
        public bool IsNullOrEmpty()
        {
            return IsNullOrEmpty("test string");
        }

        [Benchmark]
        public bool IsNullOrEmpty2()
        {
            return IsNullOrEmpty2("test string");
        }
    }
}

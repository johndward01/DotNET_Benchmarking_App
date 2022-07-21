using BenchmarkDotNet.Running;
using System;

namespace DotNET_Benchmarking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}

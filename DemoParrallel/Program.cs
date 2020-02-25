using System;
using System.Linq;

namespace DemoParallel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = CustomAggregationDemo.ParallelEnum();
            Console.WriteLine($"Sum is {sum}");
            MergeOptions.MergeOps();
        }
    }
}
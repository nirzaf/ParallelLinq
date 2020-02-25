using System;
using System.Linq;

namespace DemoParrallel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 20).ToArray();

            // FullyBuffered = all results produced before they are consumed
            // NotBuffered = each result can be consumed right after it's produced
            // Default = AutoBuffered = buffer the number of results selected by the runtime

            var results = numbers.AsParallel()
              .WithMergeOptions(ParallelMergeOptions.NotBuffered)
              .Select(x =>
              {
                  var result = Math.Log10(x);
                  Console.WriteLine($"Produced {result}");
                  return result;
              });

            foreach (var result in results)
            {
                Console.WriteLine($"Consumed {result}");
            }
        }
    }
}
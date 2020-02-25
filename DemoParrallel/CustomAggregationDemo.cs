using System.Linq;

namespace DemoParallel
{
    public static class CustomAggregationDemo
    {
        public static int ParallelEnum()
        {
            var sum = ParallelEnumerable.Range(1, 1000)
              .Aggregate(
                  0, // initial seed for calculations
                  (partialSum, i) => partialSum += i, // per task
                  (total, subtotal) => total += subtotal, // combine all tasks
                  i => i); // final result processing
            return sum;
        }
    }
}
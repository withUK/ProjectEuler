using System.Diagnostics;

namespace ProjectEuler.Models
{
    public class Problem0001 : EulerProblem
    {
        Stopwatch sw = new Stopwatch();

        public Problem0001()
        {
            Id = 1;
            Title = "Multiples of 3 and 5";
            Description = "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.";
            Completed = true;
        }

        public override object GetResult()
        {
            return SumMultiplesOfThreeAndFive();
        }

        public int GetResult(int iterations)
        {
            return SumMultiplesOfThreeAndFive(iterations);
        }

        private int SumMultiplesOfThreeAndFive(int iterations = 1000)
        {
            int result = 0;
            sw.Restart();
            
            for (int i = 3; i < iterations; i++)
            {
                if ((i % 3) == 0 || (i % 5) == 0)
                {
                    result += i;
                }
            }

            sw.Stop();
            TimeTaken = sw.Elapsed;
            return result;
        }
    }
}

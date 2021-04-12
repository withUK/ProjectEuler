using System.Diagnostics;

namespace ProjectEuler.Models
{
    public class Problem0003 : EulerProblem
    {
        Stopwatch sw = new Stopwatch();

        public Problem0003()
        {
            Id = 3;
            Title = "Largest prime factor";
            Description = "The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143?";
            Completed = true;
        }

        public override object GetResult()
        {
            return FindLargestPrimeFactor();
        }

        public int GetResult(long iterations)
        {
            return FindLargestPrimeFactor(iterations);
        }

        public int FindLargestPrimeFactor(long numm = 600851475143)
        {
            long largestFactor = 0;
            long[] factors = new long[2];

            sw.Restart();

            for (long i = 2; i * i < numm; i++)
            {
                if (numm % i == 0)
                { // It is a divisor
                    factors[0] = i;
                    factors[1] = numm / i;

                    for (int k = 0; k < 2; k++)
                    {
                        bool isPrime = true;
                        for (long j = 2; j * j < factors[k]; j++)
                        {
                            if (factors[k] % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime && factors[k] > largestFactor)
                        {
                            largestFactor = factors[k];
                        }
                    }
                }
            }

            sw.Stop();
            TimeTaken = sw.Elapsed;
            return (int)largestFactor;
        }
    }
}

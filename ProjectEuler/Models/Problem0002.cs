﻿using System.Diagnostics;

namespace ProjectEuler.Models
{
    public class Problem0002 : EulerProblem
    {
        Stopwatch sw = new Stopwatch();

        public Problem0002()
        {
            Id = 2;
            Title = "Even Fibonacci numbers";
            Description = "Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ... By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
            Completed = true;
        }

        public override object GetResult()
        {
            return TotalEvenFibonacciValues();
        }

        public int GetResult(int iterations)
        {
            return TotalEvenFibonacciValues(iterations);
        }

        private int TotalEvenFibonacciValues(int limit = 4000000)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 0;
            int result = num1;

            sw.Restart();

            while (num1 < limit)
            {
                if (CheckIsEven(num2))
                {
                    result += num2;
                }
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }

            sw.Stop();
            TimeTaken = sw.Elapsed;
            return result;
        }

        private bool CheckIsEven(int number)
        {
            if ((number % 2) == 0)
            {
                return true;
            }
            return false;
        }
    }
}

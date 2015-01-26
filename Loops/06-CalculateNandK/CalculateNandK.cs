/*
 * Problem 6. Calculate N! / K!
 * 
 * Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
 * Use only one loop.
 */

using System;

namespace _06_CalculateNandK
{
    class CalculateNandK
    {
        static void Main()
        {
            Console.Write("n = ");
            long n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            long k = int.Parse(Console.ReadLine());

            if (k <= 1 || n <= k || n >= 100)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                long factorialN = n;
                for (long i = n - 1; i >= 1; i--)
                {
                    factorialN *= i;
                }

                long factorialK = k;
                for (long i = k - 1; i >= 1; i--)
                {
                    factorialK *= i;
                }

                long sum = factorialN / factorialK;
                Console.WriteLine(sum);
            }
        }
    }
}

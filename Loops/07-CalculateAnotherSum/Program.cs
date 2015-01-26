/*
 * Problem 7. Calculate N! / (K! * (N-K)!)
 * 
 * In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 * (also known as the number of combinations) is calculated by the following formula: formula For example, 
 * there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
 * Try to use only two loops.
 */

using System;

namespace _07_CalculateAnotherSum
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (1 >= k || k >= n || n >= 100)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                double kFactorial = 1;
                double nFactorial = 1;
                double nAndKfactorial = n - k;
                double sum = 0;

                for (int i = 1, j = n - k - 1; i <= n; i++, j--)
                {
                    nFactorial *= i;
                    if (j >= 1)
                    {
                        nAndKfactorial *= j;
                    }
                }
                for (int i = 1; i <= k; i++)
                {
                    kFactorial *= i;
                }

                sum = nFactorial / (kFactorial * nAndKfactorial);
                Console.WriteLine("S = " + sum);
            }
        }
    }
}

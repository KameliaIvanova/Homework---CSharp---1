/*
 * Problem 8. Prime Number Check
 * 
 * Write an expression that checks if given positive integer number n (n <= 100) is prime
 * (i.e. it is divisible without remainder only to itself and 1).
 * Note: You should check if the number is positive
 * 
 * Examples:
 * 
 * n	Prime?
 * 1	false
 * 2	true
 * 3	true
 * 4	false
 * 9	false
 * 97	true
 * 51	false
 * -3	false
 * 0	false
 */

using System;

namespace _08_PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            int n = 3;

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("{0} true", n);
            }
            else
            {
                Console.WriteLine("{0} false", n);
            }
        }
    }
}

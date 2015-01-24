/*
 * Problem 1. Odd or Even Integers
 * 
 * Write an expression that checks if given integer is odd or even.
 * Examples:
 * 
 * n	Odd?
 * 3	true
 * 2	false
 * -2	false
 * -1	true
 * 0	false
 */

using System;

namespace _01_OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            int n = 3;

            Console.WriteLine("n Odd?");

            if (n % 2 == 0)
            {
                Console.WriteLine("{0} false", n);
            }
            else
            {
                Console.WriteLine("{0} true", n);
            }
        }
    }
}

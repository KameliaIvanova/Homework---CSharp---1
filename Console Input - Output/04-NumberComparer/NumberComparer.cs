/*
 * Problem 4. Number Comparer
 * 
 * Write a program that gets two numbers from the console and prints the greater of them.
 * Try to implement this without if statements.
 */

using System;

namespace _04_NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);
            Console.WriteLine("The greater is {0}", greater);
        }
    }
}

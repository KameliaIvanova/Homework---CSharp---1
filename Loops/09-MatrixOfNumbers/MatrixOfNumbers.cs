/*
 * Problem 9. Matrix of Numbers
 * 
 * Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix 
 * like in the examples below. Use two nested loops.
 */

using System;

namespace _09_MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter number between 1 and 20: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", j + i);

                }
                Console.WriteLine();
            }
        }
    }
}

/*
 * Problem 7. Sum of 5 Numbers
 * 
 * Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */

using System;

namespace _07_SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers, separated by a space: ");
            string input = Console.ReadLine();

            string[] fiveNumbers = input.Split(' ');

            double sum = 0;
            for (int i = 0; i < fiveNumbers.Length; i++)
            {
                sum += int.Parse(fiveNumbers[i]);
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}

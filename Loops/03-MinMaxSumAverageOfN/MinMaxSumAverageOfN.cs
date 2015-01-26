/*
 * Problem 3. Min, Max, Sum and Average of N Numbers
 * 
 * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
 * the sum and the average of all numbers (displayed with 2 digits after the decimal point).
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
 * The output is like in the examples below.
 */

using System;

namespace _03_MinMaxSumAverageOfN
{
    class MinMaxSumAverageOfN
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            double average = 0;
            double input;

            for (int i = 1; i <= n; i++)
            {
                input = double.Parse(Console.ReadLine());
                if (input < min)
                {
                    min = input;
                }
                if (input > max)
                {
                    max = input;
                }
                sum += input;
            }

            average = sum / n;
            Console.WriteLine("min = {0}   max = {1}   sum = {2}   average = {3:F2}", min, max, sum, average);
        }
    }
}

/*
 * Problem 9. Sum of n Numbers
 * 
 * Write a program that enters a number n and after that enters more n numbers and calculates and 
 * prints their sum. Note: You may need to use a for-loop.
 */

using System;

namespace _09_SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            double number;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} = ", i + 1);
                number = double.Parse(Console.ReadLine());
                sum += number;
            }
            
            Console.WriteLine("sum = " + sum);
        }
    }
}

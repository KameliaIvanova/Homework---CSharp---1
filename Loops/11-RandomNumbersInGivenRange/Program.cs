﻿/*
 * Problem 11. Random Numbers in Given Range
 * 
 * Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 */

using System;

namespace _11_RandomNumbersInGivenRange
{
    class Program
    {
        static void Main()
        {
            Console.Write("min = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max = ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (min == max)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Random randomNumber = new Random();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", randomNumber.Next(min, max + 1));
                }
            }
        }
    }
}

﻿/*
 * Problem 1. Numbers from 1 to N
 * 
 * Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
 * on a single line, separated by a space.
 */

using System;

namespace _01_NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.Write("Enter a positive integer n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", i + 1);
            }
            Console.WriteLine();
        }
    }
}

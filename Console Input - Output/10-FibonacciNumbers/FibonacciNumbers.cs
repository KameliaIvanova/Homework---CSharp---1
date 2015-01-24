/*
 * Problem 10. Fibonacci Numbers
 * 
 * Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
 * (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 * Note: You may need to learn how to use loops.
 */

using System;

namespace _10_FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int firstNumber = 0;
            int secondNumber = 1;

            Console.Write("{0}, {1}, ", firstNumber, secondNumber);
            int thirdNumber;

            for (int i = 2; i < n; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                Console.Write("{0}, ", thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
        }
    }
}

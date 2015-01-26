/*
 * Problem 10. Odd and Even Product
 * 
 * You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */

using System;

namespace _10_OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Enter n integer numbers: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int oddElements = 1;
            int evenElements = 1;
            for (int i = 0, j = 1; i < numbers.Length; i += 2, j += 2)
            {
                if (i < numbers.Length - 1)
                {
                    oddElements *= int.Parse(numbers[i]);
                    evenElements *= int.Parse(numbers[j]);
                }
                else
                {
                    oddElements *= int.Parse(numbers[i]);
                }
            }

            if (oddElements == evenElements)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + oddElements);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd product = " + oddElements);
                Console.WriteLine("even product = " + evenElements);
            }
        }
    }
}

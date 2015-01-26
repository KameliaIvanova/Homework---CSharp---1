/*
 * Problem 14. Decimal to Binary Number
 * 
 * Using loops write a program that converts an integer number to its binary representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
 */

using System;
using System.Text;

namespace _14_DecimalToBinaryNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            long decimalNumber = long.Parse(Console.ReadLine());
            long remainder;
            StringBuilder binary = new StringBuilder();

            while (decimalNumber > 0)
            {
                int index = 0;
                remainder = decimalNumber % 2;
                binary.Insert(index, remainder);

                decimalNumber /= 2;
                index++;
            }
            Console.WriteLine(binary);
        }
    }
}

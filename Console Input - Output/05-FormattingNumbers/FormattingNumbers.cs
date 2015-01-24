/*
 * Problem 5. Formatting Numbers
 * 
 * Write a program that reads 3 numbers:
 * integer a (0 <= a <= 500)
 * floating-point b
 * floating-point c
 * The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
 * The number a should be printed in hexadecimal, left aligned
 * Then the number a should be printed in binary form, padded with zeroes
 * The number b should be printed with 2 digits after the decimal point, right aligned
 * The number c should be printed with 3 digits after the decimal point, left aligned.
 */

using System;

namespace _05_FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point number: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point number: ");
            float c = float.Parse(Console.ReadLine());

            Console.Write("{0:X} | ", a);
            Console.Write(Convert.ToString(a, 2).PadLeft(8, '0') + " | ");
            Console.Write("{0,5:0.00} | ", b);
            Console.WriteLine("{0,-5:0.000} | ", c);
        }
    }
}

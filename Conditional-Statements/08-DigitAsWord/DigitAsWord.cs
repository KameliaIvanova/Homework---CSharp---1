/*
 * Problem 8. Digit as Word
 * 
 * Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 * Print “not a digit” in case of invalid input.
 * Use a switch statement.
 */

using System;

namespace _08_DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            Console.Write("Enter a digit between 0 and 9: ");
            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 0: Console.WriteLine("result: zero"); break;
                case 1: Console.WriteLine("result: one"); break;
                case 2: Console.WriteLine("result: two"); break;
                case 3: Console.WriteLine("result: three"); break;
                case 4: Console.WriteLine("result: four"); break;
                case 5: Console.WriteLine("result: five"); break;
                case 6: Console.WriteLine("result: six"); break;
                case 7: Console.WriteLine("result: seven"); break;
                case 8: Console.WriteLine("result: eight"); break;
                case 9: Console.WriteLine("result: nine"); break;
                default: Console.WriteLine("Not a digit"); break;
            }
        }
    }
}

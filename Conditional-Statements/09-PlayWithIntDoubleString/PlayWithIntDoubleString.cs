/*
 * Problem 9. Play with Int, Double and String
 * 
 * Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends * at the end.
 * Print the result at the console. Use switch statement.
 */

using System;

namespace _09_PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Console.Write("What do you want to input: 1. int, 2. double or 3. string? ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1: 
                case 2:
                    Console.Write("Enter a number: ");
                    double number = double.Parse(Console.ReadLine());
                    number += 1;
                    Console.WriteLine("number = " + number);
                    break;
                case 3:
                    Console.Write("Enter a string: ");
                    string text = Console.ReadLine();
                    text += "*";
                    Console.WriteLine("text = " + text);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}

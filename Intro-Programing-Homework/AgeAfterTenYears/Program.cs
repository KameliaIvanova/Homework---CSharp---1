/*
 * Problem 15.* Age after 10 Years
 * 
 * Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */

using System;

namespace AgeAfterTenYears
{
    class Program
    {
        static void Main()
        {
            Console.Write("Your date of birth is: ");
            byte date = byte.Parse(Console.ReadLine());

            Console.Write("Your month of birth is: ");
            byte month = byte.Parse(Console.ReadLine());

            Console.Write("Your year of birth is: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("You are now {0} years old.", DateTime.Now.Year - year);
            Console.WriteLine("After 10 years you will be {0} years old.", DateTime.Now.Year + 10 - year);
        }
    }
}

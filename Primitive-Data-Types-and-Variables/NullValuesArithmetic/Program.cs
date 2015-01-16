/*
 * Problem 12. Null Values Arithmetic
 * 
 * Create a program that assigns null values to an integer and to a double variable.
 * Try to print these variables at the console.
 * Try to add some number or the null literal to these variables and print the result.
 */

using System;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main()
        {
            int val1;
            double val2;

            Console.WriteLine("They can NOT print on the console because they are unassigned.");

            val1 = 123;
            val2 = 12.3;

            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }
    }
}

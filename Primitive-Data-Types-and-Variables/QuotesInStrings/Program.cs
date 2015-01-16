﻿/*
 * Problem 7. Quotes in Strings
 * 
 * Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
 * Do the above in two different ways - with and without using quoted strings.
 * Print the variables to ensure that their value was correctly defined.
 */

using System;

namespace QuotesInStrings
{
    class Program
    {
        static void Main()
        {
            string firstVariable = "The \"use\" of quotations causes difficulties.";
            string secondVariable = "The use of quotations causes difficulties.";

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
        }
    }
}

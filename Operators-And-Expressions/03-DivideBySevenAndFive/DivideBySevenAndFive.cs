/*
 * Problem 3. Divide by 7 and 5
 * 
 * Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
 * Examples:
 * 
 * n	Divided by 7 and 5?
 * 3	false
 * 0	false
 * 5	false
 * 7	false
 * 35	true
 * 140	true
 */

using System;

namespace _03_DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main()
        {
            int n = 35;

            Console.WriteLine("n Divided by 7 and 5?");

            if (n % 7 == 0 && n % 5 == 0)
            {
                Console.WriteLine("{0} true", n);
            }
            else
            {
                Console.WriteLine("{0} false", n);
            }
        }
    }
}

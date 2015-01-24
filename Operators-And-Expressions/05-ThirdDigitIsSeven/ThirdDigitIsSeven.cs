/*
 * Problem 5. Third Digit is 7?
 * 
 * Write an expression that checks for given integer if its third digit from right-to-left is 7.
 * Examples:
 * 
 * n	Third digit 7?
 * 5	false
 * 701	true
 * 9703	true
 * 877	false
 * 777877	false
 * 9999799	true
 */

using System;

namespace _05_ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main()
        {
            int n = 9999799;

            int firstOne = n / 10;
            int secondOne = firstOne / 10;
            int thirdOne = secondOne % 10;

            Console.WriteLine("n Third digit 7?");

            if (thirdOne == 7)
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

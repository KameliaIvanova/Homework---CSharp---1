/*
 * Problem 6. The Biggest of Five Numbers
 * 
 * Write a program that finds the biggest of five numbers by using only five if statements.
 */

using System;

namespace _06_TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("n1 = ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("n2 = ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("n3 = ");
            double n3 = double.Parse(Console.ReadLine());
            Console.Write("n4 = ");
            double n4 = double.Parse(Console.ReadLine());
            Console.Write("n5 = ");
            double n5 = double.Parse(Console.ReadLine());

            double bigger = n1;
            if (n2 > bigger)
            {
                bigger = n2;
            }
            if (n3 > bigger)
            {
                bigger = n3;
            }
            if (n4 > bigger)
            {
                bigger = n4;
            }
            if (n5 > bigger)
            {
                bigger = n5;
            }

            Console.WriteLine("The biggest: " + bigger);
        }
    }
}

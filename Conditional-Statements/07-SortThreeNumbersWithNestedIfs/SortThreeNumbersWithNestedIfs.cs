/*
 * Problem 7. Sort 3 Numbers with Nested Ifs
 * 
 * Write a program that enters 3 real numbers and prints them sorted in descending order.
 * Use nested if statements.
 * Note: Don’t use arrays and the built-in sorting functionality.
 */

using System;

namespace _07_SortThreeNumbersWithNestedIfs
{
    class SortThreeNumbersWithNestedIfs
    {
        static void Main()
        {
            Console.Write("n1 = ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("n2 = ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("n3 = ");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 >= n2)
            {
                if (n1 >= n3)
                {
                    Console.Write("{0} ", n1);
                    if (n3 >= n2)
                    {
                        Console.WriteLine("{0} {1}", n3, n2);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", n2, n3);
                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", n3, n1, n2);
                }
            }
            else
            {
                if (n2 >= n3)
                {
                    Console.Write("{0} ", n2);
                    if (n3 >= n1)
                    {
                        Console.WriteLine("{0} {1}", n3, n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", n1, n3);
                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", n3, n2, n1);
                }
            }
        }
    }
}

/*
 * Problem 9. Trapezoids
 * 
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 * Examples:
 * 
 * a	b	h	area
 * 5	7	12	72
 * 2	1	33	49.5
 * 8.5	4.3	2.7	17.28
 * 100	200	300	45000
 * 0.222	0.333	0.555	0.1540125
*/
 
using System;

namespace _09_Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a = 5;
            double b = 7;
            double h = 12;

            double area = (a + b) * h / 2;

            Console.WriteLine("a    b    h    area");
            Console.WriteLine("{0}   {1}    {2}    {3}", a, b, h, area);
        }
    }
}

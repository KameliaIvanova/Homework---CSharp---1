/*
 * Problem 6. Quadratic Equation
 * 
 * Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
 * and solves it (prints its real roots).
 */

using System;

namespace _06_QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = float.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);

            if (a != 0 && d >= 0)
            {
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else
            {
                Console.WriteLine("There are no roots!");
            }
        }
    }
}

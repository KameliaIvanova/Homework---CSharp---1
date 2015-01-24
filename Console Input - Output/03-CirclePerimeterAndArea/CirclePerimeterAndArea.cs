/*
 * Problem 3. Circle Perimeter and Area
 * 
 * Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits 
 * after the decimal point.
 */

using System;

namespace _03_CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            const double pi = 3.14;

            Console.Write("radius = ");
            double raduis = double.Parse(Console.ReadLine());

            double perimeter = 2 * pi * raduis;
            double area = pi * raduis * raduis;

            Console.WriteLine("Perimeter: {0:F2}", perimeter);
            Console.WriteLine("Area: {0:F2}", area);
        }
    }
}

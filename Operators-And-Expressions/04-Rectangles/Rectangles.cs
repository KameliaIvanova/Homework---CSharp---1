/*
 * Problem 4. Rectangles
 * 
 * Write an expression that calculates rectangle’s perimeter and area by given width and height.
 * Examples:
 * 
 * width	height	perimeter	area
 * 3	4	14	12
 * 2.5	3	11	7.5
 * 5	5	20	25
 */

using System;

namespace _04_Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = 2.5;
            double height = 3;

            double perimeter = 2 * width + 2 * height;
            double area = width * height;

            Console.WriteLine("width height perimeter area");
            Console.WriteLine();
            Console.WriteLine(width + "    " + height + "    " + perimeter + "    " + area);
        }
    }
}

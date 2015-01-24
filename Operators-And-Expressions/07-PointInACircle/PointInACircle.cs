/*
 * Problem 7. Point in a Circle
 * 
 * Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 * Examples:
 * 
 * x	y	inside
 * 0	1	true 
 * 2	0	true
 * -1	2	false
 * 1.5	-1	true
 * -1.5	-1.5	false
 * 100	-30	false
 * 0	0	true
 * 0.2	-0.8	true
 * 0.9	-1.93	false
 * 1	1.655	true
 */

using System;

namespace _07_PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            const double radius = 2;
            double x = 1.5;
            double y = -1;
            double Kx = 0;
            double Ky = 0;

            bool inside = (x - Kx) * (x - Kx) + (y - Ky) * (y - Ky) <= radius * radius;

            Console.WriteLine("x   y   inside");

            if (inside)
            {
                Console.WriteLine("{0}  {1}  true", x, y);
            }
            else
            {
                Console.WriteLine("{0}  {1}  false", x, y);
            }

        }
    }
}

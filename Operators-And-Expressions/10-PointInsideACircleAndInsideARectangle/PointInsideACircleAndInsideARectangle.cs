/*
 * Problem 10. Point Inside a Circle & Outside of a Rectangle
 * 
 * Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and 
 * out of the rectangle R(top=1, left=-1, width=6, height=2).
 * Examples:
 * 
 * x	y	inside K & outside of R
 * 1	2	yes
 * 2.5	2	no
 * 0	1	no
 * 2.5	1	no
 * 2	0	no
 * 4	0	no
 * 2.5	1.5	no
 * 2	1.5	yes
 * 1	2.5	yes
 * -100	-100	no
 */

using System;

namespace _10_PointInsideACircleAndInsideARectangle
{
    class PointInsideACircleAndInsideARectangle
    {
        static void Main()
        {
            const double radius = 1.5;
            const double Kx = 1;
            const double Ky = 1;

            double x = 2;
            double y = 1.5;

            bool inCircleOutRectangle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5
                                    && ((x < -1 || x > 5) || (y < -1 || y > 1));

            Console.WriteLine("x   y   inside K & outside of R");

            if (inCircleOutRectangle)
            {
                Console.WriteLine("{0}  {1}  yes", x, y);
            }
            else
            {
                Console.WriteLine("{0}  {1}  no", x, y);
            }
        }
    }
}

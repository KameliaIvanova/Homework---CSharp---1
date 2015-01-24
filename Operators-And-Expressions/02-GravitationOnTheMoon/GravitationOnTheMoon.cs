/*
 * Problem 2. Gravitation on the Moon
 * 
 * The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 * Examples:
 * 
 * weight	weight on the Moon
 * 86	    14.62
 * 74.6	    12.682
 * 53.7	    9.129
 */

using System;

namespace _02_GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            double weight = 53.7;

            double weightOnTheMoon = (17 / 100.0) * weight;

            Console.WriteLine("weight   weight on the moon");
            Console.WriteLine(weight + "     " + weightOnTheMoon);
        }
    }
}

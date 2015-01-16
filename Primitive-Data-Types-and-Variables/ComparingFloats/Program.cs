/*
 * Problem 13.* Comparing Floats
 * 
 * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
 * Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of 
 * the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other 
 * than a fixed constant eps.
 */


using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double firstNumber = 5.1;
            double secondNumber = 6.01;

            bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;
            Console.WriteLine("a == b --> " + equal);
        }
    }
}

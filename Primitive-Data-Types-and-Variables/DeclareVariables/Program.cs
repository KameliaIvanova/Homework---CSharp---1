﻿/*
 * Problem 1. Declare Variables
 * 
 * Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long,
 * ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
 * Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */

using System;

namespace DeclareVariables
{
    class Program
    {
        static void Main()
        {
            byte num4 = 97;
            short num2 = -115;
            short num5 = -10000;
            int num1 = 52130;
            long num3 = 4825932;
        }
    }
}
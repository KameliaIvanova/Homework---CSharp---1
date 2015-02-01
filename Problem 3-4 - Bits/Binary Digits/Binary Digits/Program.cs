using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Digits
{
    class Program
    {
        static void Main()
        {
            // Read input
            uint n = uint.Parse(Console.ReadLine());

            // Solve
            string numberInBin = Convert.ToString(n, 2).PadLeft(16, '0');
            // Console.WriteLine(numberInBin);

            // First line
            for (int i = 0; i < numberInBin.Length - 1; i++)
            {
                if (numberInBin[i] == '0') 
                {
                    Console.Write("###.");
                }
                else
                {
                    Console.Write(".#..");
                }
            }
            if (numberInBin[numberInBin.Length - 1] == '0')
            {
                Console.WriteLine("###");
            }
            else
            {
                Console.WriteLine(".#.");
            }

            // Second line
            for (int i = 0; i < numberInBin.Length - 1; i++)
            {
                if (numberInBin[i] == '0')
                {
                    Console.Write("#.#.");
                }
                else
                {
                    Console.Write("##..");
                }
            }
            if (numberInBin[numberInBin.Length - 1] == '0')
            {
                Console.WriteLine("#.#");
            }
            else
            {
                Console.WriteLine("##.");
            }

            // Third line
            for (int i = 0; i < numberInBin.Length - 1; i++)
            {
                if (numberInBin[i] == '0')
                {
                    Console.Write("#.#.");
                }
                else
                {
                    Console.Write(".#..");
                }
            }
            if (numberInBin[numberInBin.Length - 1] == '0')
            {
                Console.WriteLine("#.#");
            }
            else
            {
                Console.WriteLine(".#.");
            }

            // Forth line
            for (int i = 0; i < numberInBin.Length - 1; i++)
            {
                if (numberInBin[i] == '0')
                {
                    Console.Write("###.");
                }
                else
                {
                    Console.Write("###.");
                }
            }
            if (numberInBin[numberInBin.Length - 1] == '0')
            {
                Console.WriteLine("###");
            }
            else
            {
                Console.WriteLine("###");
            }
        }
    }
}

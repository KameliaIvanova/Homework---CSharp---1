using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Program
    {
        static void Main()
        {
            // Read the input
            int n = int.Parse(Console.ReadLine());

            // Output first row
            for (int i = 1; i <= n; i++)
            {
                Console.Write('.');
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();

            // Output middle rows
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write('.');
                }
                Console.Write('*');

                for (int j = 1; j <= i + n - 3; j++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                Console.WriteLine();
            }

            // Output last row
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}

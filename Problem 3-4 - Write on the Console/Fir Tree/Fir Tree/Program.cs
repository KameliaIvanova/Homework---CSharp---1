using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fir_Tree
{
    class Program
    {
        static void Main()
        {
            // Read the input
            int n = int.Parse(Console.ReadLine());

            // Write the tree
            for (int i = 0; i < n - 1; i++)
            {
                string dots = new string('.', (n - i) - 2);
                string stars = new string('*', (i * 2) + 1);

                Console.Write(dots);
                Console.Write(stars);
                Console.Write(dots);

                Console.WriteLine();
            }

            // Write the stem
            string finalDots = new string('.', n - 2);

            Console.Write(finalDots);
            Console.Write("*");
            Console.Write(finalDots);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // Top part of fire
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('.', n / 2 - i));
                Console.Write('#');
                Console.Write(new string('.', (i - 1) * 2));
                Console.Write('#');
                Console.WriteLine(new string('.', n / 2 - i));
            }

            // Bottom part of fire
            for (int i = 1; i <= n / 4; i++)
            {
                Console.Write(new string('.', i - 1));
                Console.Write('#');
                Console.Write(new string('.', (n / 2 - i) * 2));
                Console.Write('#');
                Console.WriteLine(new string('.', i - 1));
            }

            // Top part of torch
            Console.WriteLine(new string('-', n));

            // Torch
            for (int i = 1; i <= n / 2; i++)
			{
			    Console.Write(new string('.', i - 1));
                Console.Write(new string('\\', n / 2 - (i - 1)));
                Console.Write(new string('/', n / 2 - (i - 1)));
                Console.WriteLine(new string('.', i - 1));
			}
        }
    }
}

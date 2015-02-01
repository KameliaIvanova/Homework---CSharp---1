using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspichania_Boats
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int width = size * 2 + 1;
            int height = 6 + ((size - 3) / 2) * 2;

            int middleDotsCounts = 0;
            string firstLineDots = new string('.', (width - 1) / 2);

            Console.WriteLine("{0}*{0}", firstLineDots);

            for (int row = size; row > 0; row--)
            {
                int begginingDotsCount = row - 1;
                string begginingDots = new string('.', begginingDotsCount);

                if (middleDotsCounts <= size - 2)
                {
                    string middleDots = new string('.', middleDotsCounts);
                    Console.WriteLine("{0}*{1}*{1}*{0}", begginingDots, middleDots);
                    middleDotsCounts++;
                }
            }

            var onlyStarsLine = new string('*', width);
            Console.WriteLine(onlyStarsLine);

            for (int row = 0; row < height / 3 - 1; row++)
            {
                int outerDotsCount = row + 1;
                string outerDots = new string('.', outerDotsCount);
                int innerDotsCount = (width - outerDotsCount * 2 - 3) / 2;
                string innerDots = new string('.', innerDotsCount);

                Console.WriteLine("{0}*{1}*{1}*{0}", outerDots, innerDots);
            }

            string startAndEndDots = new string('.', (width - size) / 2);
            string bottomSide = new string('*', size);

            Console.WriteLine("{0}{1}{0}", startAndEndDots, bottomSide);
        }
    }
}

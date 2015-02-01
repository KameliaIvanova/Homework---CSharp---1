using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Trolls
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int width = size * 2 + 1;
            int height = 6 + ((size - 3) / 2) * 3;

            string firstLineDots = new string('.', (width - size) / 2);
            string firstLineStars = new string('*', size);

            Console.WriteLine("{0}{1}{0}", firstLineDots, firstLineStars);

            for (int row = 0; row < height / 3 - 1; row++)
            {
                int dotsCount = (width - 3) / 4 - row;
                string endsDots = new string('.', dotsCount);
                string middleDots = new string('.', (width - 2 * dotsCount - 3) / 2);

                Console.WriteLine("{0}*{1}*{1}*{0}", endsDots, middleDots);
            }

            string middleSymbols = new string('*', size * 2 - 1);
            Console.WriteLine("*{0}*", middleSymbols);

            int middleDotsCounts = size - 2;

            for (int row = 0; row < size; row++)
            {
                int begginingDotsCount = row + 1;
                string begginingDots = new string('.', begginingDotsCount);

                if (middleDotsCounts >= 0)
                {
                    string middleDots = new string('.', middleDotsCounts);

                    Console.WriteLine("{0}*{1}*{1}*{0}", begginingDots, middleDots);
                    middleDotsCounts--;
                }
                else
                {
                    Console.WriteLine("{0}*{0}", begginingDots);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long result = 0;
            switch (b)
            {
                case 2:
                    result = a % c;
                    break;
                case 4:
                    result = a + c;
                    break;
                case 8:
                    result = a * c;
                    break;
            }

            double resultDividedBy4 = 0;
            if (result % 4 == 0)
            {
                resultDividedBy4 = result / 4;
            }
            else
            {
                resultDividedBy4 = result % 4;
            }

            Console.WriteLine(resultDividedBy4);
            Console.WriteLine(result);
        }
    }
}

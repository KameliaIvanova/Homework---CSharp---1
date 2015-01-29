using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peace_of_Cake
{
    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            long resultNominator = a * d + b * c;
            long resultDenominator = b * d;
            decimal result = ((decimal)resultNominator / resultDenominator);

            if (result >= 1)
            {
                Console.WriteLine((long)result);
            }
            else
            {
                Console.WriteLine("{0:F22}", result);
            }
            Console.WriteLine(resultNominator + "/" + resultDenominator);
        }
    }
}

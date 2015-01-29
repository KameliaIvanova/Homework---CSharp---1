using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Math_Expression
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal n = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());

            decimal nominator = n * n + (1 / (m * p) + 1337);
            decimal denominator = n - 128.523123123m * p;
            int a = (int)m % 180;
            decimal sin = (decimal)Math.Sin(a);

            decimal result = nominator / denominator + sin;

            Console.WriteLine("{0:F6}", result);
        }
    }
}

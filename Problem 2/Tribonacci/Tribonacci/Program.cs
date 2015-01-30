using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Tribonacci
{
    class Program
    {
        static void Main()
        {
            // Read input
            BigInteger num1 = new BigInteger(int.Parse(Console.ReadLine()));
            BigInteger num2 = new BigInteger(int.Parse(Console.ReadLine()));
            BigInteger num3 = new BigInteger(int.Parse(Console.ReadLine()));

            int n = int.Parse(Console.ReadLine());

            // Solve the task
            if (n == 1)
            {
                Console.WriteLine(num1);
            }
            else if (n == 2)
            {
                Console.WriteLine(num2);
            }
            else if (n == 3)
            {
                Console.WriteLine(num3);
            }
            else
            {
                for (int i = 4; i <= n; i++)
                {
                    BigInteger numNew = num1 + num2 + num3;
                    num1 = num2;
                    num2 = num3;
                    num3 = numNew;
                }
                Console.WriteLine(num3);
            }
        }
    }
}

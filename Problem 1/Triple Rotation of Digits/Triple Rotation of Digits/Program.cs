using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Rotation_of_Digits
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 3; i++)
            {
                if (k >= 10)
                {
                    int lastDigit = k % 10;
                    int firstDigits = k / 10;
                    k = int.Parse("" + lastDigit + firstDigits);
                }
            }
            Console.WriteLine(k);
        }
    }
}

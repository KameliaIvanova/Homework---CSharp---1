using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Coffee_Vending_Machine
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int line1 = int.Parse(Console.ReadLine());
            int line2 = int.Parse(Console.ReadLine());
            int line3 = int.Parse(Console.ReadLine());
            int line4 = int.Parse(Console.ReadLine());
            int line5 = int.Parse(Console.ReadLine());

            decimal givenAmount = decimal.Parse(Console.ReadLine());
            decimal drinkPrice = decimal.Parse(Console.ReadLine());

            if (givenAmount < drinkPrice)
            {
                decimal difference = drinkPrice - givenAmount;
                Console.WriteLine("More {0:F2}", difference);
            }
            else
            {
                decimal moneyInTrays = 0.05m * line1 + 0.10m * line2 + 0.20m * line3 + 0.50m * line4 + 1.00m * line5;
                decimal changeToGive = givenAmount - drinkPrice;
                decimal difference = Math.Abs(moneyInTrays - changeToGive);

                if (changeToGive <= moneyInTrays)
                {
                    Console.WriteLine("Yes {0:F2}", difference);
                }
                else
                {
                    Console.WriteLine("No {0:F2}", difference);
                }
            }
        }
    }
}

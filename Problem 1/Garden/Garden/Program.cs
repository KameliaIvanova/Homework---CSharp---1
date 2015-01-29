using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Garden
{
    class Program
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;

            int tomatoSeed = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine()); 
            int cucumberSeed = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine()); 
            int potatoSeed = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine()); 
            int carrotSeed = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine()); 
            int cabbageSeed = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine()); 
            int beansSeed = int.Parse(Console.ReadLine());

            double tomatoCost = 0.5;
            double cucumberCost = 0.4;
            double potatoCost = 0.25;
            double carrotCost = 0.6;
            double cabbageCost = 0.3;
            double beansCost = 0.4;

            double totalCost = tomatoSeed * tomatoCost + cucumberSeed * cucumberCost + potatoSeed * potatoCost + carrotSeed * carrotCost + cabbageSeed * cabbageCost + beansCost * beansSeed;
            Console.WriteLine("Total costs: {0:F2}", totalCost);

            int beansArea = 250 - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;

            if (beansArea > 0 )
            {
                Console.WriteLine("Beans area: {0}", beansArea);
            }
            else if (beansArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}

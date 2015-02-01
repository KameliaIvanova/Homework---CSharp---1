using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace We_All_Love_Bits_
{
    class Program
    {
        static void Main()
        {
            // Read n
            int n = int.Parse(Console.ReadLine());

            // For all n numbers
            for (int i = 1; i <= n; i++)
            {
                // Read p
                int p = int.Parse(Console.ReadLine());

                // Solve
                int Pnew = 0;

                while (p > 0)
                {
                    Pnew <<= 1;
                    if ((p & 1) == 1)
                    {
                        Pnew |= 1;
                    }
                    p >>= 1;
                }

                // Write Pnew
                Console.WriteLine(Pnew);
            }
        }
    }
}

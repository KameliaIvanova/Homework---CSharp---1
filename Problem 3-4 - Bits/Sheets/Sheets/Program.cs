using System;

namespace Sheets
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 10; i >= 0; i--)
            {
                if ((n & 1) == 0) // Check if last bit is zero
                {
                    Console.WriteLine("A{0}", i);
                }
                n >>= 1;
            }
        }
    }
}

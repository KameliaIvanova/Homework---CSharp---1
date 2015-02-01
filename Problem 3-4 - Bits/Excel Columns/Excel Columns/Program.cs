using System;

namespace Excel_Columns
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long index = 0; // If n > 12 we should use bigger data type

            for (int i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                index *= 26;
                index += ch - 'A' + 1;
            }
            Console.WriteLine(index);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadronacci_Rectangle
{
    class Program
    {
        static void Main()
        {
            try
            {
                checked
                {
                    long first = long.Parse(Console.ReadLine());
                    long second = long.Parse(Console.ReadLine());
                    long third = long.Parse(Console.ReadLine());
                    long foutrh = long.Parse(Console.ReadLine());

                    ulong rows = ulong.Parse(Console.ReadLine());
                    ulong cols = ulong.Parse(Console.ReadLine());

                    ulong lastToGenerate = rows * cols;

                    if (cols > 0)
                    {
                        Console.Write("{0} {1} {2} {3} ", first, second, third, foutrh);
                    }
                    else
                    {
                        Console.Write("{0} {1} {2} {3} ", first, second, third, foutrh);
                    }

                    for (ulong currentPosition = 5; currentPosition <= lastToGenerate; currentPosition++)
                    {
                        if ((currentPosition - 1) % cols == 0)
                        {
                            Console.WriteLine();
                        }

                        long currentNumber = first + second + third + foutrh;

                        if (currentPosition % cols != 0)
                        {
                            Console.Write(currentNumber + " ");
                        }
                        else
                        {
                            Console.Write(currentNumber);
                        }

                        first = second;
                        second = third;
                        third = foutrh;
                        foutrh = currentNumber;
                    }
                }

                Console.WriteLine();
            }
            catch 
            {
                Console.WriteLine();
                Console.WriteLine("Overflow or other error");
                throw;
            }
        }
    }
}

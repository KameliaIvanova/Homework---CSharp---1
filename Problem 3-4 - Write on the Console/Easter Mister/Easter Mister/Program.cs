﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Mister
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int height = size * 2;
            int width = 3 * size + 1;
            int roundedPart = size / 2;

            for (int row = 0; row < height; row++)
            {
                if (row == 0 || row == height - 1)
                {
                    string dotsOnFirstOrLastLine = new string('.', size + 1);
                    string startOnFirstOrLastLine = new string('*', size - 1);

                    Console.WriteLine("{0}{1}{0}", dotsOnFirstOrLastLine, startOnFirstOrLastLine);
                }
                else if (row < roundedPart)
                {
                    int dotsOnBeginAndEndCount = size + 1 - row * 2;
                    var dotsOnBeginAndEndLine = new string('.', dotsOnBeginAndEndCount);
                    var middleDots = new string('.', size + 1 + 4 * (row - 1));

                    Console.WriteLine("{0}*{1}*{0}", dotsOnBeginAndEndLine, middleDots);
                }
                else if (row - size > roundedPart - 1)
                {
                    int dotsOnBeginAndEndCount = size + 1 - (height - row - 1) * 2;
                    var dotsOnBeginAndEndLine = new String('.', dotsOnBeginAndEndCount);
                    var middleDots = new String('.', size + 1 + 4 * (height - row - 2));
                    Console.WriteLine("{0}*{1}*{0}", dotsOnBeginAndEndLine, middleDots);
                }
                else
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (row == size - 1)
                        {
                            if (col == 0 || col == width - 1)
                            {
                                Console.Write('.');
                            }
                            else if (col == 1 || col == width - 2)
                            {
                                Console.Write('*');
                            }
                            else
                            {
                                if (col % 2 == 0)
                                {
                                    Console.Write('.');
                                }
                                else
                                {
                                    Console.Write('#');
                                }
                            }
                        }
                        else if (row == size)
                        {
                            if (col == 0 || col == width - 1)
                            {
                                Console.Write('.');
                            }
                            else if (col == 1 || col == width - 2)
                            {
                                Console.Write('*');
                            }
                            else
                            {
                                if (col % 2 == 1)
                                {
                                    Console.Write('.');
                                }
                                else
                                {
                                    Console.Write('#');
                                }
                            }
                        }
                        else
                        {
                            string middleDots = new string('.', width - 4);

                            Console.Write(".*{0}*.", middleDots);
                            break;
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

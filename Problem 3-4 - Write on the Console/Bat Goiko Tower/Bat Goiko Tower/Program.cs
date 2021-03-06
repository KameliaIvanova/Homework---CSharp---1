﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bat_Goiko_Tower
{
    class Program
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int width = h * 2;

            int towerWidth = 2;
            int nextCrossbeamRow = 2;
            int currentStep = 2;

            for (int row = 1; row <= h; row++)
            {
                string sidePoints = new string('.', (width - towerWidth) / 2);
                string middleSymbols;

                if (row % nextCrossbeamRow == 0)
                {
                    middleSymbols = new string('-', width - (sidePoints.Length * 2) - 2);
                    nextCrossbeamRow += currentStep;
                    currentStep++;
                }
                else
                {
                    middleSymbols = new string('.', width - (sidePoints.Length * 2) - 2);
                }

                Console.WriteLine(sidePoints + "/" + middleSymbols + "\\" + sidePoints);

                towerWidth += 2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using TestConsole.StockSeries;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckStraightLineClass test = new CheckStraightLineClass();
            int[][] coordinates = new int[][] { new int[] { 0, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
            bool result = test.CheckStraightLine(coordinates);
        }
    }
}

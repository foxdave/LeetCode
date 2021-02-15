using System;
using System.Collections.Generic;
using TestConsole.StockSeries;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = { new int[] { 0, 1, 2, 3, 4 }, new int[] { 24, 23, 22, 21, 5 } ,new int[] { 12, 13, 14, 15, 16 },
            new int[]{11,17,18,19,20 },new int[]{ 10, 9, 8, 7, 6 } };
            int result = new SwimInWaterClass().SwimInWater(grid);
        }
    }
}

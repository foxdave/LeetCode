using System;
using System.Collections.Generic;
using TestConsole.StockSeries;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = { new int[] { 1, 2 }, new int[] { 3, 4 } };
            int[][] result = new MatrixReshapeClass().MatrixReshape(nums, 4, 1);
        }
    }
}

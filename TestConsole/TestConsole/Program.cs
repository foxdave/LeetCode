using System;
using System.Collections.Generic;
using TestConsole.StockSeries;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 4, 7 };
            int result = new FindLengthOfLCISClass().FindLengthOfLCIS(nums);
        }
    }
}

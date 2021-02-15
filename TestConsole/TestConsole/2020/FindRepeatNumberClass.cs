using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
   public class FindRepeatNumberClass
    {
        public int FindRepeatNumber(int[] nums)
        {
            int[] record = new int[100000];
            for (int i = 0; i < nums.Length; i++)
            {
                record[nums[i]]++;
                if (record[nums[i]] > 1)
                {
                    return nums[i];
                }
            }
            return -1;
        }
    }
}
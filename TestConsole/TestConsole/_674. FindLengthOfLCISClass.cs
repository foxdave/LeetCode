using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class FindLengthOfLCISClass
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int maxLCIS = 1;
            int tempMax = 1;
            int pointer = 0;
            for (int i = pointer; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    tempMax++;
                    continue;
                }
                maxLCIS = maxLCIS < tempMax ? tempMax : maxLCIS;
                pointer = i + 1;
                tempMax = 1;
            }
            maxLCIS = maxLCIS < tempMax ? tempMax : maxLCIS;
            return maxLCIS;
        }
    }
}

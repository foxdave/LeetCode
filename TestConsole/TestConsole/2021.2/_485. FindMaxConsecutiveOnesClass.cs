using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class FindMaxConsecutiveOnesClass
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCOne = 0;
            int currentCOne = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    currentCOne = 0;
                }
                if (nums[i] == 1)
                {
                    currentCOne++;
                }
                if (currentCOne > maxCOne)
                {
                    maxCOne = currentCOne;
                }
            }
            return maxCOne;
        }
    }
}

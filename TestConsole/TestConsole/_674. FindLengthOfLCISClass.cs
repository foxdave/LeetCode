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
            int tempMaxLCIS;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                tempMaxLCIS = 1;
                for (int j = i; j < nums.Length - 1; j++)
                {
                    if (nums[j] < nums[j + 1])
                    {
                        tempMaxLCIS++;
                        if (maxLCIS < tempMaxLCIS)
                        {
                            maxLCIS = tempMaxLCIS;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return maxLCIS;
        }
    }
}

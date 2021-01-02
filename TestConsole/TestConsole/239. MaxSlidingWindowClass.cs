using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace TestConsole
{
    public class MaxSlidingWindowClass
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int length = nums.Length;
            int[] result = new int[length - k + 1];
            LinkedList<int> maxValIndexQueue = new LinkedList<int>();
            for (int i = 0; i < length; i++)
            {
                if (maxValIndexQueue.Count != 0 && maxValIndexQueue.First.Value < i - k + 1)
                {
                    maxValIndexQueue.RemoveFirst();
                }
                while (maxValIndexQueue.Count != 0 && nums[maxValIndexQueue.Last.Value] <= nums[i])
                {
                    maxValIndexQueue.RemoveLast();
                }
                maxValIndexQueue.AddLast(i);
                if (i >= k - 1)
                {
                    result[i - k + 1] = nums[maxValIndexQueue.First.Value];
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class NextGreaterElements2Class
    {
        public int[] NextGreaterElements(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int length = nums.Length;
            int[] result = new int[length];
            Array.Fill(result, -1);
            for (int i = 0; i < length * 2 - 1; i++)
            {
                while (stack.Count != 0 && nums[stack.Peek()] < nums[i % length])
                {
                    result[stack.Pop()] = nums[i % length];
                }
                stack.Push(i % length);
            }
            return result;
        }
    }
}

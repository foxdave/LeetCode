using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class NextGreaterElementClass
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();//nums2每个元素对应的下一个更大的元素
            Stack<int> stack = new Stack<int>(nums2.Length);//用来计算生成dic
            int[] result = new int[nums1.Length];//返回的结果
            for (int i = 0; i < nums2.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(nums2[i]);
                    continue;
                }
                while (stack.Count != 0 && stack.Peek() < nums2[i])
                {
                    dic.Add(stack.Pop(), nums2[i]);
                }
                stack.Push(nums2[i]);
            }
            while (stack.Count != 0)
            {
                dic.Add(stack.Pop(), -1);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = dic[nums1[i]];
            }
            return result;
        }
    }
}

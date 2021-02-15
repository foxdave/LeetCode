using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class RemoveKdigits
    {
        public string DoWork(string num, int k)
        {
            if (num.Length == k)
            {
                return "0";
            }
            Stack numStack = new Stack();
            numStack.Push(num[0]);
            for (int i = 1; i < num.Length; i++)
            {
                while (numStack.Count != 0 && k != 0 && (num[i] < (char)numStack.Peek()))
                {
                    numStack.Pop();
                    k--;
                }
                numStack.Push(num[i]);
            }
            while (k > 0)
            {
                numStack.Pop();
                k--;
            }
            string result = string.Empty;
            while (numStack.Count != 0)
            {
                result = numStack.Pop() + result;
            }
            return result.TrimStart('0').Length == 0 ? "0" : result.TrimStart('0');
        }
    }
}

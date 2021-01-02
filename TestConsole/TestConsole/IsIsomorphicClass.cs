using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestConsole
{
    public class IsIsomorphicClass
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    if (map.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    map[s[i]] = t[i];
                    continue;
                }
                else
                {
                    if (map[s[i]] != t[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

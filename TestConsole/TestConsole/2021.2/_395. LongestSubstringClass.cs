using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestConsole
{
    public class LongestSubstringClass
    {
        public int LongestSubstring(string s, int k)
        {
            if (k == 1) { return s.Length; }
            if (s.Length < k) { return 0; }

            char[] chars = s.ToCharArray();
            List<char> distChars = chars.Distinct().ToList();
            Dictionary<char, int> charsCount = new Dictionary<char, int>(distChars.Count);
            for (int i = 0; i < distChars.Count; i++)
            {
                charsCount[distChars[i]] = chars.Count(c => c == distChars[i]);
            }
            foreach (var charDic in charsCount)
            {
                if (charDic.Value < k)
                {
                    int res = 0;
                    string[] subStrs = s.Split(charDic.Key);
                    foreach (string subStr in subStrs)
                    {
                        if (subStr.Length >= k)
                        {
                            res = Math.Max(res, LongestSubstring(subStr, k));
                        }
                    }
                    return res;
                }
            }
            return s.Length;
        }
    }
}

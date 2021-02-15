using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class StringRotationLCCIClass
    {
        public bool IsFlipedString(string s1, string s2)
        {
            return (s1.Length == s2.Length) && (s1 + s1).IndexOf(s2) > -1;
        }
    }
}

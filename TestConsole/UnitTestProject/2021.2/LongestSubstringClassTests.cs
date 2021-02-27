using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class LongestSubstringClassTests
    {
        [TestMethod()]
        public void LongestSubstringTest1()
        {
            string s = "aaabb";
            int k = 3;
            int expectResult = 3;
            int actualResult = new LongestSubstringClass().LongestSubstring(s, k);
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod()]
        public void LongestSubstringTest2()
        {
            string s = "ababbc";
            int k = 2;
            int expectResult = 5;
            int actualResult = new LongestSubstringClass().LongestSubstring(s, k);
            Assert.AreEqual(expectResult, actualResult);
        }
    }
}
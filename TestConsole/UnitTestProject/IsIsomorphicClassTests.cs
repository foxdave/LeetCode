using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class IsIsomorphicClassTests
    {
        [TestMethod()]
        public void IsIsomorphicTest1()
        {
            string s = "egg", t = "add";
            bool expectedResult = true;
            bool actualResult = new IsIsomorphicClass().IsIsomorphic(s, t);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void IsIsomorphicTest2()
        {
            string s = "foo", t = "bar";
            bool expectedResult = false;
            bool actualResult = new IsIsomorphicClass().IsIsomorphic(s, t);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void IsIsomorphicTest3()
        {
            string s = "paper", t = "title";
            bool expectedResult = true;
            bool actualResult = new IsIsomorphicClass().IsIsomorphic(s, t);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void IsIsomorphicTest4()
        {
            string s = "ab", t = "aa";
            bool expectedResult = false;
            bool actualResult = new IsIsomorphicClass().IsIsomorphic(s, t);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class FIBClassTests
    {
        [TestMethod()]
        public void FIBTest1()
        {
            int n = 2;
            int expectedResult = 1;
            int actualResult = new FIBClass().FIB(n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void FIBTest2()
        {
            int n = 3;
            int expectedResult = 2;
            int actualResult = new FIBClass().FIB(n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void FIBTest3()
        {
            int n = 4;
            int expectedResult = 3;
            int actualResult = new FIBClass().FIB(n);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
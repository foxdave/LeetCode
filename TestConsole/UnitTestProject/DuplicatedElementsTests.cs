using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class DuplicatedElementsTests
    {
        [TestMethod()]
        public void ContainsDuplicateTest1()
        {
            int[] arrays = new int[] { 1, 2, 3, 1 };
            bool expectedResult = true;
            bool actualResult = new DuplicatedElements().ContainsDuplicate(arrays);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ContainsDuplicateTest2()
        {
            int[] arrays = new int[] { 1, 2, 3, 4 };
            bool expectedResult = false;
            bool actualResult = new DuplicatedElements().ContainsDuplicate(arrays);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ContainsDuplicateTest3()
        {
            int[] arrays = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool expectedResult = true;
            bool actualResult = new DuplicatedElements().ContainsDuplicate(arrays);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
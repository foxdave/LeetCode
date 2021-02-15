using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class FindLengthOfLCISClassTests
    {
        [TestMethod()]
        public void FindLengthOfLCISTest1()
        {
            int[] nums = new int[] { 1, 3, 5, 4, 7 };
            int expectedResult = 3;
            int actualResult = new FindLengthOfLCISClass().FindLengthOfLCIS(nums);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void FindLengthOfLCISTest2()
        {
            int[] nums = new int[] { 2, 2, 2, 2, 2 };
            int expectedResult = 1;
            int actualResult = new FindLengthOfLCISClass().FindLengthOfLCIS(nums);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
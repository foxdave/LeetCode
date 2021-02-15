using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class FindMaxConsecutiveOnesClassTests
    {
        [TestMethod()]
        public void FindMaxConsecutiveOnesTest()
        {
            int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
            int expectedResult = 3;
            int actualResult = new FindMaxConsecutiveOnesClass().FindMaxConsecutiveOnes(nums);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
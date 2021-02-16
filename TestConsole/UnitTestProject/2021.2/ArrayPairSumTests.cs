using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class ArrayPairSumTests
    {
        [TestMethod()]
        public void ArrayPairSumTest1()
        {
            int[] nums = new int[] { 1, 4, 3, 2 };
            int expectedResult = 4;
            int actualResult = new ArrayPairSumClass().ArrayPairSum(nums);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ArrayPairSumTest2()
        {
            int[] nums = new int[] { 6, 2, 6, 5, 1, 2 };
            int expectedResult = 9;
            int actualResult = new ArrayPairSumClass().ArrayPairSum(nums);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
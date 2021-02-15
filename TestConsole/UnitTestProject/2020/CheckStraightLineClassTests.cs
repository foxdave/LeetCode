using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class CheckStraightLineClassTests
    {
        [TestMethod()]
        public void CheckStraightLineTest1()
        {
            int[][] coordinates = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 5, 6 }, new int[] { 6, 7 } };
            bool expectedResult = true;
            bool actualResult = new CheckStraightLineClass().CheckStraightLine(coordinates);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CheckStraightLineTest2()
        {
            int[][] coordinates = new int[][] { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 5, 6 }, new int[] { 7, 7 } };
            bool expectedResult = false;
            bool actualResult = new CheckStraightLineClass().CheckStraightLine(coordinates);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
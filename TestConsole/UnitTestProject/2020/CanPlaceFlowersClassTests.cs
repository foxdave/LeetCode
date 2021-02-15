using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class CanPlaceFlowersClassTests
    {
        [TestMethod()]
        public void CanPlaceFlowersTest1()
        {
            int[] flowerbed = new int[] { 1, 0, 0, 0, 1 };
            int n = 1;
            bool expectedResult = true;
            bool actualResult = new CanPlaceFlowersClass().CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CanPlaceFlowersTest2()
        {
            int[] flowerbed = new int[] { 1, 0, 0, 0, 1 };
            int n = 2;
            bool expectedResult = false;
            bool actualResult = new CanPlaceFlowersClass().CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CanPlaceFlowersTest3()
        {
            int[] flowerbed = new int[] { 0 };
            int n = 1;
            bool expectedResult = true;
            bool actualResult = new CanPlaceFlowersClass().CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
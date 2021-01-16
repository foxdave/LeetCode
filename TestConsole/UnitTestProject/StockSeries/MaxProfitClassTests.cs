using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole.StockSeries;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.StockSeries.Tests
{
    [TestClass()]
    public class MaxProfitClassTests
    {
        [TestMethod()]
        public void MaxProfit1Test1()
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int expectedResult = 5;
            int actualResult = new MaxProfitClass().MaxProfit1(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit1Test2()
        {
            int[] prices = new int[] { 7, 6, 4, 3, 1 };
            int expectedResult = 0;
            int actualResult = new MaxProfitClass().MaxProfit1(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit2Test1()
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int expectedResult = 7;
            int actualResult = new MaxProfitClass().MaxProfit2(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit2Test2()
        {
            int[] prices = new int[] { 1, 2, 3, 4, 5 };
            int expectedResult = 4;
            int actualResult = new MaxProfitClass().MaxProfit2(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit2Test3()
        {
            int[] prices = new int[] { 7, 6, 4, 3, 1 };
            int expectedResult = 0;
            int actualResult = new MaxProfitClass().MaxProfit2(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit3Test1()
        {
            int[] prices = new int[] { 3, 3, 5, 0, 0, 3, 1, 4 };
            int expectedResult = 6;
            int actualResult = new MaxProfitClass().MaxProfit3(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit3Test2()
        {
            int[] prices = new int[] { 1, 2, 3, 4, 5 };
            int expectedResult = 4;
            int actualResult = new MaxProfitClass().MaxProfit3(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit3Test3()
        {
            int[] prices = new int[] { 7, 6, 4, 3, 1 };
            int expectedResult = 0;
            int actualResult = new MaxProfitClass().MaxProfit3(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit3Test4()
        {
            int[] prices = new int[] { 1 };
            int expectedResult = 0;
            int actualResult = new MaxProfitClass().MaxProfit3(prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit4Test1()
        {
            int[] prices = new int[] { 2, 4, 1 };
            int k = 2;
            int expectedResult = 2;
            int actualResult = new MaxProfitClass().MaxProfit4(k, prices);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MaxProfit4Test2()
        {
            int[] prices = new int[] { 3, 2, 6, 5, 0, 3 };
            int k = 2;
            int expectedResult = 7;
            int actualResult = new MaxProfitClass().MaxProfit4(k, prices);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
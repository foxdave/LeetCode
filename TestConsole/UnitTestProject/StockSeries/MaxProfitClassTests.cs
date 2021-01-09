﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
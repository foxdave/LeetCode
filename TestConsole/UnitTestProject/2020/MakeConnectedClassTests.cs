using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class MakeConnectedClassTests
    {
        [TestMethod()]
        public void MakeConnectedTest1()
        {
            int n = 4;
            int[][] connections = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 2 } };
            int expectedResult = 1;
            int actualResult = new MakeConnectedClass().MakeConnected(n, connections);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MakeConnectedTest2()
        {
            int n = 6;
            int[][] connections = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 0, 3 },
            new int[] { 1, 2 }, new int[] { 1, 3 }};
            int expectedResult = 2;
            int actualResult = new MakeConnectedClass().MakeConnected(n, connections);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MakeConnectedTest3()
        {
            int n = 6;
            int[][] connections = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 0, 3 },
            new int[] { 1, 2 }};
            int expectedResult = -1;
            int actualResult = new MakeConnectedClass().MakeConnected(n, connections);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MakeConnectedTest4()
        {
            int n = 5;
            int[][] connections = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 3, 4 },
            new int[] { 2, 3 }};
            int expectedResult = 0;
            int actualResult = new MakeConnectedClass().MakeConnected(n, connections);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
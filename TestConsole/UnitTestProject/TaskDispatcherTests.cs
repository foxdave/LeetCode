using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Tests
{
    [TestClass()]
    public class TaskDispatcherTests
    {
        [TestMethod()]
        public void LeastIntervalTest1()
        {
            var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' };
            var n = 2;
            var expectedResult = 8;
            var actualResult = new TaskDispatcher().LeastInterval(tasks, n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void LeastIntervalTest2()
        {
            var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' };
            var n = 0;
            var expectedResult = 6;
            var actualResult = new TaskDispatcher().LeastInterval(tasks, n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void LeastIntervalTest3()
        {
            var tasks = new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            var n = 2;
            var expectedResult = 16;
            var actualResult = new TaskDispatcher().LeastInterval(tasks, n);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
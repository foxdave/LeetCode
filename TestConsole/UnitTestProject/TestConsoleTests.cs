using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;

namespace UnitTestProject
{
    [TestClass]
    public class TestConsoleTests
    {
        [TestMethod]
        public void RemoveKdigitsTest1()
        {
            RemoveKdigits obj = new RemoveKdigits();
            string expected = "1219";
            string actual = obj.DoWork("1432219", 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveKdigitsTest2()
        {
            RemoveKdigits obj = new RemoveKdigits();
            string expected = "200";
            string actual = obj.DoWork("10200", 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveKdigitsTest3()
        {
            RemoveKdigits obj = new RemoveKdigits();
            string expected = "0";
            string actual = obj.DoWork("10", 2);
            Assert.AreEqual(expected, actual);
        }

        public void RemoveKdigitsTest4()
        {
            RemoveKdigits obj = new RemoveKdigits();
            string expected = "0";
            string actual = obj.DoWork("10", 1);
            Assert.AreEqual(expected, actual);
        }
    }
}

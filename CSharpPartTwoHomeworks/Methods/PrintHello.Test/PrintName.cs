using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrintHello.Test
{
    [TestClass]
    public class PrintName
    {
        [TestMethod]
        public void PrintNameTest()
        {
            string actual = Hello.PrintName("Georgi");

            string expected = "Hello, Georgi!";

            Assert.AreEqual(expected, actual);
        }
    }
}

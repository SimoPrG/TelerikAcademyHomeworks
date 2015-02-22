using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppearanceCount.Test
{
    [TestClass]
    public class AppearanceCountTest
    {
        [TestMethod]
        public void AppearanceCountIfCheckNumberIsInArray()
        {
            int[] arr = { 1, 1, 1, 1, 2, 2, 2, 8, 9, 9, 9, 9, 9 };
            int numCheck = 9;
            int actual = AppearanceCountApp.AppearanceCount(arr, numCheck);
            int expected = 5;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AppearanceCountIfCheckNumberIsNotInArray()
        {
            int[] arr = { 1, 1, 1, 1, 2, 2, 2, 8, 9, 9, 9, 9, 9 };
            int numCheck = 3;
            int actual = AppearanceCountApp.AppearanceCount(arr, numCheck);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AppearanceCountIfCheckNumberIsNegative()
        {
            int[] arr = { 1, 1, 1, 1, -3, 2, 2, 2, 8, -3, 9, 9, 9, -3, 9, 9 };
            int numCheck = -3;
            int actual = AppearanceCountApp.AppearanceCount(arr, numCheck);
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }
    }
}

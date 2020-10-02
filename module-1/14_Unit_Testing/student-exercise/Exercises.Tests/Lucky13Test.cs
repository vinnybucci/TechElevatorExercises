using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void GetLuckyTest()
        {
            Lucky13 lucky13 = new Lucky13();

            bool result = lucky13.GetLucky(new int[] { 0, 2, 4 });
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void GetLuckyTest123()
        {
            Lucky13 lucky13 = new Lucky13();

            bool result = lucky13.GetLucky(new int[] { 1, 2, 3 });
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void GetLuckyTest124()
        {
            Lucky13 lucky13 = new Lucky13();

            bool result = lucky13.GetLucky(new int[] { 1, 2, 4 });
            Assert.AreEqual(false, result);
        }
    }
}
/*
        Given an array of ints, return true if the array contains no 1's and no 3's.
        GetLucky([0, 2, 4]) → true
        GetLucky([1, 2, 3]) → false
        GetLucky([1, 2, 4]) → false
        */
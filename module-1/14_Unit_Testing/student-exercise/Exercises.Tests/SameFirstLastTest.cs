using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void ItIsTheSameTest()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            int[] input = { 1, 2, 3 };
            bool result = sameFirstLast.IsItTheSame(input);
            Assert.AreEqual(false, input);

            

        }
        [TestMethod]
        public void ItIsTheSameTestTrue()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();

            int[] parameter = { 1, 2, 3, 1 };
            bool value = sameFirstLast.IsItTheSame(parameter);
            Assert.AreEqual(true, value);
        }
        [TestMethod]
        public void ItIsTheSameTestTrue121()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();

            int[] parameter = { 1, 2, 1 };
            bool value = sameFirstLast.IsItTheSame(parameter);
            Assert.AreEqual(true, value);
        }
    }
}
/*
        Given an array of ints, return true if the array is length 1 or more, and the first element and
        the last element are equal.
        IsItTheSame([1, 2, 3]) → false
        IsItTheSame([1, 2, 3, 1]) → true
        IsItTheSame([1, 2, 1]) → true
        */
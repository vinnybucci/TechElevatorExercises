using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
   public  class MaxEnd3Test
    {
        [TestMethod]
        public void MakeArrayTest()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            int[] first = { 1, 2, 3, };
            int[] expected = { 3, 3, 3 };
            int[] result = maxEnd3.MakeArray(first);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void MakeArrayTest1159()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            int[] first = { 11, 5, 9, };
            int[] expected = { 11, 11, 11 };
            int[] result = maxEnd3.MakeArray(first);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void MakeArrayTest2113()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            int[] first = { 2, 11, 3, };
            int[] expected = { 3, 3, 3 };
            int[] result = maxEnd3.MakeArray(first);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
/*
         Given an array of ints length 3, figure out which is larger between the first and last elements 
         in the array, and set all the other elements to be that value. Return the changed array.
         MakeArray([1, 2, 3]) → [3, 3, 3]
         MakeArray([11, 5, 9]) → [11, 11, 11]
         MakeArray([2, 11, 3]) → [3, 3, 3]
         */
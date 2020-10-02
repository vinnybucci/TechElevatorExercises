using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
   public  class Less20Test
    {
        [TestMethod]
        public void LessThan20Test()
        {
            Less20 less20 = new Less20();
            int input = 18;
            bool expected = true;
            bool result;
            bool lessTest = less20.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, lessTest);

        }
        [TestMethod]
        public void LessThan20Test19()
        {
            Less20 less20 = new Less20();
            int input = 19;
            bool expected = true;
            bool result;
            bool lessTest = less20.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, lessTest);

        }
        [TestMethod]
        public void LessThan20Test20()
        {
            Less20 less20 = new Less20();
            int input = 20;
            bool expected = false;
            bool result;
            bool lessTest = less20.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, lessTest);

        }
    }
}
/*
        Return true if the given non-negative number is 1 or 2 less than a multiple of 20. So for example 38 
        and 39 return true, but 40 returns false. 
        (Hint: Think "mod".)
        less20(18) → true
        less20(19) → true
        less20(20) → false
        */
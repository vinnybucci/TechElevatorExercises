using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
   public  class StringBitsTest
    {
        [TestMethod]
        public void GetBitsTest()
        {
            StringBits stringBits = new StringBits();
            string expected = "Hlo";
            string result = "";
            string input = "Hello";

            result = stringBits.GetBits(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetBitsTestH()
        {
            StringBits stringBits = new StringBits();
            string expected = "H";
            string result = "";
            string input = "Hi";

            result = stringBits.GetBits(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetBitsTestHeeololeo()
        {
            StringBits stringBits = new StringBits();
            string expected = "Hello";
            string result = "";
            string input = "Heeololeo";

            result = stringBits.GetBits(input);
            Assert.AreEqual(expected, result);
        }
    }
}
/*
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         GetBits("Hello") → "Hlo"	
         GetBits("Hi") → "H"	
         GetBits("Heeololeo") → "Hello"	
         */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void StringTest()
        {
            FrontTimes frontTimes = new FrontTimes();
            string input = "Chocolate";
            int input2 = 2;
            string expected = "ChoCho";
            string result = "";
            result = frontTimes.GenerateString(input, input2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void StringTestChoChoCho()
        {
            FrontTimes frontTimes = new FrontTimes();
            string input = "Chocolate";
            int input2 = 3;
            string expected = "ChoChoCho";
            string result = "";
            result = frontTimes.GenerateString(input, input2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void StringTestAbcAbcAbc()
        {
            FrontTimes frontTimes = new FrontTimes();
            string input = "Abc";
            int input2 = 3;
            string expected = "AbcAbcAbc";
            string result = "";
            result = frontTimes.GenerateString(input, input2);
            Assert.AreEqual(expected, result);
        }
    }
}
/*
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or 
         whatever is there if the string is less than length 3. Return n copies of the front;
         frontTimes("Chocolate", 2) → "ChoCho"	
         frontTimes("Chocolate", 3) → "ChoChoCho"	
         frontTimes("Abc", 3) → "AbcAbcAbc"	
         */
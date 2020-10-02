using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void PartialStringTest()
        {
            NonStart nonStart = new NonStart();
            string expected = "ellohere";
            string input = "Hello";
            string input2 = "There";
            string result = "";
           
            
            result = nonStart.GetPartialString(input, input2);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void PartialStringTestavaode()
        {
            NonStart nonStart = new NonStart();
            string expected = "avaode";
            string input = "java";
            string input2 = "code";
            string result = "";


            result = nonStart.GetPartialString(input, input2);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void PartialStringTesthotlava()
        {
            NonStart nonStart = new NonStart();
            string expected = "hotlava";
            string input = "shotl";
            string input2 = "java";
            string result = "";


            result = nonStart.GetPartialString(input, input2);

            Assert.AreEqual(expected, result);
        }
    }
}
/*
         Given 2 strings, return their concatenation, except omit the first char of each. The strings will 
         be at least length 1.
         GetPartialString("Hello", "There") → "ellohere"
         GetPartialString("java", "code") → "avaode"	
         GetPartialString("shotl", "java") → "hotlava"	
         */
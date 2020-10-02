using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void GetCountTest()
        {
            WordCount wordCount = new WordCount();
            string[] input = { "ba", "ba", "black", "sheep" };
            Dictionary<string, int> result = wordCount.GetCount(input);
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "ba" , 2},{"black", 1 },{"sheep", 1 }};
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetCountTestabacb()
        {
            WordCount wordCount = new WordCount();
            string[] input = { "a", "b", "a", "c", "b" };
            Dictionary<string, int> result = wordCount.GetCount(input);
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "a", 2}, {"b", 2}, {"c", 1} };
            CollectionAssert.AreEqual(expected, result);
        }
       
        [TestMethod]
        public void GetCountTestcba()
        {
            WordCount wordCount = new WordCount();
            string[] input = { "c", "b", "a" };
            Dictionary<string, int> result = wordCount.GetCount(input);
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "c", 1 }, {"b", 1}, {"a", 1 }
    };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
/*
        * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
        * number of times that string appears in the array.
        * 
        * ** A CLASSIC **
        * 
        * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
        * GetCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
        * GetCount([]) → {}
        * GetCount(["c", "b", "a"]) → {"c": 1, "b": 1, "a": 1}
        * 
        */
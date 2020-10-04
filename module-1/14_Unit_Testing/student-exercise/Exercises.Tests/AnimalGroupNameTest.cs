using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
   public class AnimalGroupNameTest
    {
        //* If the name of the animal is not found, null, or empty, return "unknown". 
        //GetHerd("giraffe") → "Tower"
        // * GetHerd("") -> "unknown"         
        // * GetHerd("walrus") -> "unknown"
        // * GetHerd("Rhino") -> "Crash"
        // * GetHerd("rhino") -> "Crash"
        // * GetHerd("elephants") -> "unknown"
        [TestMethod]
        public void GetHerdPath()
        {
            //Arrange 
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "Crash";
            string input = "Rhino";
            string result = "";

            //Act 
            result = animalGroupName.GetHerd(input);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetHerdPathEmpty()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "unknown";
            string input = "";
            string result = "";

            //Act 
            result = animalGroupName.GetHerd(input);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetHerdPathGiraffe()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "Tower";
            string input = "giraffe";
            string result = "";

            //Act 
            result = animalGroupName.GetHerd(input);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetHerdPathWalrus()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "unknown";
            string input = "walrus";
            string result = "";

            //Act 
            result = animalGroupName.GetHerd(input);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetHerdPathRhino()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "Crash";
            string input = "rhino";
            string result = "";

            //Act 
            result = animalGroupName.GetHerd(input);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetHerdPathElephants()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "unknown";
            string input = "elephants";
            string result = "";

            //Act 
            result = animalGroupName.GetHerd(input);
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetHerdPathNull()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            string expected = "unknown";
            string input = null;
            string result = "";

            //Act 
            result = animalGroupName.GetHerd(input);
            //Assert 
            Assert.AreEqual(expected, result);
        }

    }
}

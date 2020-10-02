using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        /*
         When squirrels get together for a party, they like to have cigars. A squirrel party is successful
         when the number of cigars is between 40 and 60, inclusive. Unless it is the weekend, in which case 
         there is no upper bound on the number of cigars. Return true if the party with the given values is 
         successful, or false otherwise.
         haveParty(30, false) → false
         haveParty(50, false) → true
         haveParty(70, true) → true
         */

        [TestMethod]
        public void HavePartyTest()
        {
            //arange 
            CigarParty cigarParty = new CigarParty();
            bool partyTest = cigarParty.HaveParty(30, false);
            Assert.AreEqual(partyTest, false);
            //act

            //assert
        }
        [TestMethod]
        public void HavePartyTest50()
        {
            //arange 
            CigarParty cigarParty = new CigarParty();
            bool partyTest = cigarParty.HaveParty(50, false);
            Assert.AreEqual(partyTest, true);
        }
        [TestMethod]
        public void HavePartyTest70()
        {
            //arange 
            CigarParty cigarParty = new CigarParty();
            bool partyTest = cigarParty.HaveParty(70, true);
            Assert.AreEqual(partyTest, true);
        }



    }
}

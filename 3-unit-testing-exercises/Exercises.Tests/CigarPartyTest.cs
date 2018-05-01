using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        CigarParty thisCigarParty = new CigarParty();

        [TestMethod]
        public void CigarPartyTest30False()
        {
            bool result = thisCigarParty.HaveParty(30, false);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CigarPartyTest50False()
        {
            bool result = thisCigarParty.HaveParty(50, false);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CigarPartyTest70True()
        {
            bool result = thisCigarParty.HaveParty(70, true);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    /* OPTIONAL */
    [TestClass]
    public class KataPrimeFactorsTests
    {
        [TestMethod]
        public void PrimeFactorTest()
        {
            KataPrimeFactors thisKata = new KataPrimeFactors();
            CollectionAssert.AreEquivalent(new int[] { 2, 2, 3 }, thisKata.Factorize(12));
            CollectionAssert.AreEquivalent(new int[] { 2, 2, 2, 2 }, thisKata.Factorize(16));
            CollectionAssert.AreEquivalent(new int[] { 7 }, thisKata.Factorize(7));
            CollectionAssert.AreEquivalent(new int[] { 2, 2, 2, 11 }, thisKata.Factorize(88));

        }

    }


}

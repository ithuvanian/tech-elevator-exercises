using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {

        [TestMethod]
        public void RomanNumeralsToDigitsTest()
        {
            KataRomanNumerals thisKata = new KataRomanNumerals();
            Assert.AreEqual(3300, thisKata.ConvertToDigit("MMMCCC"));
            Assert.AreEqual(330, thisKata.ConvertToDigit("CCCXXX"));
            Assert.AreEqual(24, thisKata.ConvertToDigit("XXIV"));
            Assert.AreEqual(5, thisKata.ConvertToDigit("V"));
            Assert.AreEqual(1240, thisKata.ConvertToDigit("MCCXL"));
            Assert.AreEqual(12, thisKata.ConvertToDigit("XII"));
            Assert.AreEqual(999, thisKata.ConvertToDigit("CMXCIX"));
            Assert.AreEqual(78, thisKata.ConvertToDigit("LXXVIII"));

        }

        [TestMethod]
        public void DigitsToRomanNumeralsTest()
        {
            KataRomanNumerals getRomanNumTest = new KataRomanNumerals();
            Assert.AreEqual("MMMCCC", getRomanNumTest.ConvertToRomanNumeral(3300));
            Assert.AreEqual("CCCXXX", getRomanNumTest.ConvertToRomanNumeral(330));
            Assert.AreEqual("XXIV", getRomanNumTest.ConvertToRomanNumeral(24));
            Assert.AreEqual("V", getRomanNumTest.ConvertToRomanNumeral(5));
            Assert.AreEqual("MCCXL", getRomanNumTest.ConvertToRomanNumeral(1240));
            Assert.AreEqual("XII", getRomanNumTest.ConvertToRomanNumeral(12));
            Assert.AreEqual("CMXCIX", getRomanNumTest.ConvertToRomanNumeral(999));
            Assert.AreEqual("LXXVIII", getRomanNumTest.ConvertToRomanNumeral(78));
        }
    }
}

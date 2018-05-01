using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExercises;

namespace TDDExercises.Tests
{
    [TestClass]
    public class NumbersToWordsTest
    {
        [TestMethod]
        public void NumbersWordsTest()
        {
            NumbersToWords thisNumbersToWords = new NumbersToWords();
            Assert.AreEqual("zero", thisNumbersToWords.OutputWords(0));
            Assert.AreEqual("nine", thisNumbersToWords.OutputWords(9));
            Assert.AreEqual("fifteen", thisNumbersToWords.OutputWords(15));
            Assert.AreEqual("twenty", thisNumbersToWords.OutputWords(20));
            Assert.AreEqual("thirty-three", thisNumbersToWords.OutputWords(33));
            Assert.AreEqual("one hundred", thisNumbersToWords.OutputWords(100));
            Assert.AreEqual("one hundred and one", thisNumbersToWords.OutputWords(101));

            Assert.AreEqual("one hundred and twenty-one", thisNumbersToWords.OutputWords(121));
            Assert.AreEqual("nine hundred", thisNumbersToWords.OutputWords(900));
            Assert.AreEqual("two thousand", thisNumbersToWords.OutputWords(2000));
            Assert.AreEqual("five thousand, two hundred and forty-seven", thisNumbersToWords.OutputWords(5247));
            Assert.AreEqual("eleven thousand", thisNumbersToWords.OutputWords(11000));
            Assert.AreEqual("thirty-three thousand", thisNumbersToWords.OutputWords(33000));
            Assert.AreEqual("sixty-nine thousand, nine hundred and ten", thisNumbersToWords.OutputWords(69910));
            Assert.AreEqual("one hundred thousand", thisNumbersToWords.OutputWords(100000));
            Assert.AreEqual("two hundred thirty-four thousand, six hundred and fifty-four", thisNumbersToWords.OutputWords(234654));


        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExercises;

namespace TDDExercises.Tests
{
    [TestClass]
    public class WordsToNumbersTest
    {
        [TestMethod]
        public void WordsToNumbersMethodTest()
        {
            WordsToNumbers thisTest = new WordsToNumbers();
            Assert.AreEqual(0, thisTest.OutputInts("zero"));
            Assert.AreEqual(75, thisTest.OutputInts("seventy five"));
            Assert.AreEqual(332, thisTest.OutputInts("three hundred and thirty two"));
            Assert.AreEqual(2406, thisTest.OutputInts("two thousand, four hundred and six"));
            Assert.AreEqual(72897, thisTest.OutputInts("seventy two thousand, eight hundred and ninety seven"));
            Assert.AreEqual(551701, thisTest.OutputInts("five hundred and fifty one thousand, seven hundred and one"));
            Assert.AreEqual(7, thisTest.OutputInts("seven"));
            Assert.AreEqual(12, thisTest.OutputInts("twelve"));
            Assert.AreEqual(22, thisTest.OutputInts("twenty two"));

        }
    }   
}

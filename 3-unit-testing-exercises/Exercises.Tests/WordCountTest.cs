using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        WordCount thisWordCount = new WordCount();

        [TestMethod]
        public void WordCountTestBlackSheep()
        {
            string[] parameter = { "ba", "ba", "black", "sheep" };
            Dictionary<string, int> result = thisWordCount.GetCount(parameter);
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "ba", 2 },
                { "black", 1 },
                { "sheep", 1 }
            };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WordCountTestBlank()
        {
            string[] parameter = { };
            Dictionary<string, int> result = thisWordCount.GetCount(parameter);
            Dictionary<string, int> expected = new Dictionary<string, int>();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}

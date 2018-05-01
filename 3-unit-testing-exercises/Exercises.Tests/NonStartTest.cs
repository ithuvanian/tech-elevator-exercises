using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        NonStart thisNonStart = new NonStart();

        [TestMethod]
        public void NonStartTestHelloThere()
        {
            string result = thisNonStart.GetPartialString("hello", "there");
            Assert.AreEqual("ellohere", result);
        }

        [TestMethod]
        public void NonStartTestHotLava()
        {
            string result = thisNonStart.GetPartialString("shotl", "java");
            Assert.AreEqual("hotlava", result);
        }
    }
}

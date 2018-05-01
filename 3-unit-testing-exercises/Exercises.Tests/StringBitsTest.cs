using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        StringBits thisStringBits = new StringBits();

        [TestMethod]
        public void StringBitsTestHello()
        {
            string result = thisStringBits.GetBits("Hello");
            Assert.AreEqual("Hlo", result);
        }

        [TestMethod]
        public void StringBitsTestHi()
        {
            string result = thisStringBits.GetBits("Hi");
            Assert.AreEqual("H", result);
        }
    }
}

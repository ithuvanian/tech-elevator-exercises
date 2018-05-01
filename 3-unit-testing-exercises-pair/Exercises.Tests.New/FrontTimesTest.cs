using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        FrontTimes thisTest = new FrontTimes();
        [TestMethod]
        public void GenerateStringTest()
        {
            string result = thisTest.GenerateString("Chocolate", 2);
            Assert.AreEqual("ChoCho", result);

        }
        [TestMethod]
        public void GenerateStringTestTwo()
        {
            string result = thisTest.GenerateString("Abc", 3);
            Assert.AreEqual("AbcAbcAbc", result);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        Less20 thisTest = new Less20();
        [TestMethod]
        public void IsLessThanMultipleOf20Test()
        {
            bool result = thisTest.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsLessThanMultipleOf20TestTwo()
        {
            bool result = thisTest.IsLessThanMultipleOf20(20);
            Assert.AreEqual(false, result);
        }
    }
}

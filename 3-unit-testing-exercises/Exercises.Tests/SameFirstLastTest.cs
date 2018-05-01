using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        SameFirstLast thisSameFirstLast = new SameFirstLast();

        [TestMethod]
        public void SameFirstLastFalse()
        {
            int[] parameter = { 1, 2, 3 };
            bool result = thisSameFirstLast.IsItTheSame(parameter);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void SameFirstLastTrue()
        {
            int[] parameter = { 3, 2, 3 };
            bool result = thisSameFirstLast.IsItTheSame(parameter);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void SameFirstLastNoValue()
        {
            int[] parameter = { };
            bool result = thisSameFirstLast.IsItTheSame(parameter);
            Assert.AreEqual(false, result);
        }
    }
}

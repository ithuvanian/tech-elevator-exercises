using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {

        Lucky13 thisLucky13 = new Lucky13();

        [TestMethod]
        public void Lucky13TestNo1No3()
        {
            int[] parameter = { 0, 2, 4 };
            bool result = thisLucky13.GetLucky(parameter);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Lucky13Test1And3()
        {
            int[] parameter = { 1, 4, 3 };
            bool result = thisLucky13.GetLucky(parameter);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Lucky13Test1No3()
        {
            int[] parameter = { 1, 4, 2 };
            bool result = thisLucky13.GetLucky(parameter);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Lucky13Test3No1()
        {
            int[] parameter = { 7, 4, 3 };
            bool result = thisLucky13.GetLucky(parameter);
            Assert.AreEqual(false, result);
        }
    }
}

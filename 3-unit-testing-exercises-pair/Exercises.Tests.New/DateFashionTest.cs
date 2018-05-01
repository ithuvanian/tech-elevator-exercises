using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        DateFashion thisDateFashion = new DateFashion();
        [TestMethod]
        public void GetATableTest()
        {

            int result = thisDateFashion.GetATable(9, 9);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void GetATableTestTwo()
        {
            int result = thisDateFashion.GetATable(2, 2);
            Assert.AreEqual(0, result);
        }
    }
}

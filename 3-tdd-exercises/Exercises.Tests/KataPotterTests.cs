using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataPotterTests
    {
        [TestMethod]
        public void PotterTest()
        {
            KataPotter thisKata = new KataPotter();
            int[] books1 = { 3, 2, 1, 5, 1, 3 };
            Assert.AreEqual(40.8M, thisKata.GetCost(books1));
            //int[] books2 = { 1, 2, 4, 3, 5, 3, 2 };
            //Assert.AreEqual(42, thisKata.GetCost(books2));
            int[] books3 = { 2 };
            Assert.AreEqual(8, thisKata.GetCost(books3));
            int[] books4 = { 1, 2, 4, 5 };
            Assert.AreEqual(25.6M, thisKata.GetCost(books4));
            int[] books5 = { 2, 4 };
            Assert.AreEqual(15.2M, thisKata.GetCost(books5));

        }
    }
}


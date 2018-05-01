using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzzTest()
        {
            KataFizzBuzz thisKata = new KataFizzBuzz();
            Assert.AreEqual("", thisKata.FizzBuzz(-1));
            Assert.AreEqual("1", thisKata.FizzBuzz(1));
            Assert.AreEqual("Fizz", thisKata.FizzBuzz(3));
            Assert.AreEqual("Buzz", thisKata.FizzBuzz(5));
            Assert.AreEqual("FizzBuzz", thisKata.FizzBuzz(15));
            Assert.AreEqual("Fizz", thisKata.FizzBuzz(18));
            Assert.AreEqual("19", thisKata.FizzBuzz(19));
            Assert.AreEqual("FizzBuzz", thisKata.FizzBuzz(30));
            Assert.AreEqual("Buzz", thisKata.FizzBuzz(35));
            Assert.AreEqual("Fizz", thisKata.FizzBuzz(99));
            Assert.AreEqual("", thisKata.FizzBuzz(101));
        }
    }
}

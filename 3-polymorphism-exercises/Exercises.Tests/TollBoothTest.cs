using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator;

namespace Exercises.Tests
{
    [TestClass]
    public class TollBoothTest
    {
        [TestMethod]
        public void CarClassTest()
        {
            Car withoutTrailer = new Car(false);
            Car withTrailer = new Car(true);
            Assert.AreEqual(false, withoutTrailer.HasTrailer);
            Assert.AreEqual(true, withTrailer.HasTrailer);
        }

        [TestMethod]
        public void TruckClassTest()
        {
            Truck FourAxles = new Truck(4);
            Truck EightAxles = new Truck(8);
            Assert.AreEqual(4, FourAxles.NumberOfAxles);
            Assert.AreEqual(8, EightAxles.NumberOfAxles);
        }

        [TestMethod]
        public void TankClassTest()
        {
            Tank LookItsATank = new Tank();
            Assert.AreEqual(LookItsATank.ToString(), "Tank");
        }
    }
}

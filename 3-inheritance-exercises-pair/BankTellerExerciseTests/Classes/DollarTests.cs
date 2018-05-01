using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class DollarTests
    {


        [TestMethod]
        public void ToStringTest()
        {
            DollarAmount thisTest = new DollarAmount(90, 50);
            string results = thisTest.ToString();
            Assert.AreEqual("$90.50", results);
        }

        [TestMethod]
        public void PlusTest()
        {
            DollarAmount thisTest = new DollarAmount(90);
            DollarAmount addingTest = new DollarAmount(10);
            DollarAmount answer = new DollarAmount(100);
            DollarAmount result = thisTest.Plus(addingTest);
            Assert.AreEqual(answer.Dollars, result.Dollars);
            Assert.AreEqual(answer.Cents, result.Cents);
        }


        [TestMethod]
        public void MinusTest()
        {
            DollarAmount thisTest = new DollarAmount(90);
            DollarAmount addingTest = new DollarAmount(10);
            DollarAmount answer = new DollarAmount(80);
            DollarAmount result = thisTest.Minus(addingTest);
            Assert.AreEqual(answer.Dollars, result.Dollars);
            Assert.AreEqual(answer.Cents, result.Cents);
        }

        

    }
}

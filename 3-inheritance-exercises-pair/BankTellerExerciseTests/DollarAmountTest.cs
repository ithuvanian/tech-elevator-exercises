using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class DollarAmountTest
    {
        [TestMethod]
        public void AddDollarAmountTest()
        {
            DollarAmount thisDollarAmount = new DollarAmount(111);
            DollarAmount dollarAmountToAdd = new DollarAmount(222);
            DollarAmount addedAmount = thisDollarAmount.Plus(dollarAmountToAdd);
            Assert.AreEqual(333, (addedAmount.Dollars * 100) + addedAmount.Cents);
        }

        [TestMethod]
        public void SubtractDollarAmountTest()
        {
            DollarAmount thisDollarAmount = new DollarAmount(333);
            DollarAmount dollarAmountToSubtract = new DollarAmount(111);
            DollarAmount subtractedAmount = thisDollarAmount.Minus(dollarAmountToSubtract);
            Assert.AreEqual(222, (subtractedAmount.Dollars * 100) + subtractedAmount.Cents);
        }

        [TestMethod]
        public void DollarAmountToStringTest()
        {
            DollarAmount thisDollarAmount = new DollarAmount(1140);
            string result = thisDollarAmount.ToString();
            Assert.AreEqual("$11.40", result);
        }

    }
}

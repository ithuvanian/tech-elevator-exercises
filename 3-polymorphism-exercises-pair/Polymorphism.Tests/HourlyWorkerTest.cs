using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll;

namespace Polymorphism.Tests
{
    [TestClass]
    public class HourlyWorkerTest
    {
        [TestMethod]
        public void HourlyTest()
        {
            HourlyWorker thisWorker = new HourlyWorker(20, "John", "Doe", 40);
            double totalPay = thisWorker.CalculateWeeklyPay(thisWorker.HoursWorked);
            Assert.AreEqual(800, totalPay);

        }

        [TestMethod]
        public void HourlyOvertimeTest()
        {
            HourlyWorker thisWorker = new HourlyWorker(20, "John", "Doe", 45);
            double totalPay = thisWorker.CalculateWeeklyPay(thisWorker.HoursWorked);
            Assert.AreEqual(950, totalPay);
        }
    }
}

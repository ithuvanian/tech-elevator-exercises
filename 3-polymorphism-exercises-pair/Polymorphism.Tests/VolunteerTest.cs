using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll;

namespace Polymorphism.Tests
{
    [TestClass]
    public class VolunteerTest
    {
        [TestMethod]
        public void VolunteerMethodTest()
        {
            VolunteerWorker thisWorker = new VolunteerWorker("Jane", "Doe", 40);
            double totalPay = thisWorker.CalculateWeeklyPay(thisWorker.HoursWorked);
            Assert.AreEqual(0, totalPay);
        }
    }
}

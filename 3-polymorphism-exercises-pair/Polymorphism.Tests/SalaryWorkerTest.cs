using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll;

namespace Polymorphism.Tests
{
    [TestClass]
    public class SalaryWorkerTest
    {
        [TestMethod]
        public void SalaryMethodTest()
        {
            SalaryWorker thisWorker = new SalaryWorker(104000, "John", "Fulton", 2345);
            double totalPay = thisWorker.CalculateWeeklyPay(thisWorker.HoursWorked);
            Assert.AreEqual(2000, totalPay);
        }
    }
}

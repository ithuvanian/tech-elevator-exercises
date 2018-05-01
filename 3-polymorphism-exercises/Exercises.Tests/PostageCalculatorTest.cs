using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator;

namespace Exercises.Tests
{
    [TestClass]
    public class PostageCalculatorTest
    {
        [TestMethod]
        public void USPSFirstClassTest()
        {
            PostalService USPS1 = new PostalService(1);
            double rate1 = USPS1.CalculateRate(3, 333);
            double rate2 = USPS1.CalculateRate(333, 333);
            double rate3 = USPS1.CalculateRate(3, 3);
            double rate4 = USPS1.CalculateRate(333, 3);

            Assert.AreEqual("$1.50", rate1.ToString("$0.00"));
            Assert.AreEqual("$166.50", rate2.ToString("$0.00"));
            Assert.AreEqual("$0.12", rate3.ToString("$0.00"));
            Assert.AreEqual("$13.32", rate4.ToString("$0.00"));

        }

        [TestMethod]
        public void USPSSecondClassTest()
        {
            PostalService USPS2 = new PostalService(2);
            double rate1 = USPS2.CalculateRate(3, 333);
            double rate2 = USPS2.CalculateRate(333, 333);
            double rate3 = USPS2.CalculateRate(3, 3);
            double rate4 = USPS2.CalculateRate(333, 3);

            Assert.AreEqual("$0.15", rate1.ToString("$0.00"));
            Assert.AreEqual("$16.65", rate2.ToString("$0.00"));
            Assert.AreEqual("$0.01", rate3.ToString("$0.00"));
            Assert.AreEqual("$1.33", rate4.ToString("$0.00"));
        }

        [TestMethod]
        public void USPSThirdClassTest()
        {
            PostalService USPS3 = new PostalService(3);
            double rate1 = USPS3.CalculateRate(333, 3);
            double rate2 = USPS3.CalculateRate(333, 333);
            double rate3 = USPS3.CalculateRate(3, 333);
            double rate4 = USPS3.CalculateRate(33, 33);

            Assert.AreEqual("$0.73", rate1.ToString("$0.00"));
            Assert.AreEqual("$5.66", rate2.ToString("$0.00"));
            Assert.AreEqual("$0.05", rate3.ToString("$0.00"));
            Assert.AreEqual("$0.50", rate4.ToString("$0.00"));
        }

        [TestMethod]
        public void FexEdTest()
        {
            FexEd FXD = new FexEd();
            double rate1 = FXD.CalculateRate(400, 47);
            double rate2 = FXD.CalculateRate(400, 49);
            double rate3 = FXD.CalculateRate(600, 47);
            double rate4 = FXD.CalculateRate(600, 49); 

            Assert.AreEqual("$20.00", rate1.ToString("$0.00"));
            Assert.AreEqual("$23.00", rate2.ToString("$0.00"));
            Assert.AreEqual("$25.00", rate3.ToString("$0.00"));
            Assert.AreEqual("$28.00", rate4.ToString("$0.00"));
        }


        [TestMethod]
        public void SPUFourDayTest()
        {
            SPUFourDay SPU4 = new SPUFourDay();
            double rate1 = SPU4.CalculateRate(333, 3*16);
            double rate2 = SPU4.CalculateRate(333, 333*16);
            double rate3 = SPU4.CalculateRate(33, 33*16);

            Assert.AreEqual("$5.00", rate1.ToString("$0.00"));
            Assert.AreEqual("$554.45", rate2.ToString("$0.00"));
            Assert.AreEqual("$5.45", rate3.ToString("$0.00"));
        }


        [TestMethod]
        public void SPUTwoDayTest()
        {
            SPUTwoDay SPU2 = new SPUTwoDay();
            double rate1 = SPU2.CalculateRate(333, 3*16);
            double rate2 = SPU2.CalculateRate(333, 333*16);
            double rate3 = SPU2.CalculateRate(33, 33*16);

            Assert.AreEqual("$49.95", rate1.ToString("$0.00"));
            Assert.AreEqual("$5544.45", rate2.ToString("$0.00"));
            Assert.AreEqual("$54.45", rate3.ToString("$0.00"));
        }


        [TestMethod]
        public void SPUNextDayTest()
        {
            SPUNextDay SPU1 = new SPUNextDay();
            double rate1 = SPU1.CalculateRate(333, 3*16);
            double rate2 = SPU1.CalculateRate(333, 333*16);
            double rate3 = SPU1.CalculateRate(33, 33*16);

            Assert.AreEqual("$74.93", rate1.ToString("$0.00"));
            Assert.AreEqual("$8316.68", rate2.ToString("$0.00"));
            Assert.AreEqual("$81.68", rate3.ToString("$0.00"));
        }
    }
}

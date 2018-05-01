using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExercises;

namespace TDDExercises.Tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void StringTest()
        {
            StringCalculator thisCalculator = new StringCalculator();
            Assert.AreEqual(0, thisCalculator.GetSum(""));
            Assert.AreEqual(1, thisCalculator.GetSum("1"));
            Assert.AreEqual(10, thisCalculator.GetSum("5,5"));
            Assert.AreEqual(40, thisCalculator.GetSum("5,5,4,3,6,3,6,8"));
            Assert.AreEqual(40, thisCalculator.GetSum("5\n5,4,3\n6\n3,6,8"));
            //Assert.AreEqual(40, thisCalculator.GetSum("//!\n5!5!4!3!6!3!6!8")/*delimeters*/);



        }
    }
}

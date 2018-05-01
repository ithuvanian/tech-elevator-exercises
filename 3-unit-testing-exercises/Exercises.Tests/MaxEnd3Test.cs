using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        MaxEnd3 thisMaxEnd3 = new MaxEnd3();

        [TestMethod]
        public void MaxEndTestAll3()
        {
            int[] parameter = { 1, 2, 3 };
            int[] result = thisMaxEnd3.MakeArray(parameter);
            int[] expected = { 3, 3, 3 };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MaxEndTestAll11()
        {
            int[] parameter = { 11, 2, 3 };
            int[] result = thisMaxEnd3.MakeArray(parameter);
            int[] expected = { 11, 11, 11 };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MaxEndTestAll4()
        {
            int[] parameter = { 4, 22, 2 };
            int[] result = thisMaxEnd3.MakeArray(parameter);
            int[] expected = { 4, 4, 4 };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}

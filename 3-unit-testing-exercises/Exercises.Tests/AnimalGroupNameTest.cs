using System;
<<<<<<< HEAD
using Exercises;
=======
>>>>>>> a7f2bd226e9aba47b9b96c7403312c809d7f1352
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
<<<<<<< HEAD
        AnimalGroupName testAnimalGroup = new AnimalGroupName();

        [TestMethod]
        public void AnimalGroupTestLowercase()
        {
            string output = testAnimalGroup.GetHerd("rhino");
            string expectedOutput = "Crash";
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void AnimalGroupTestUppercase()
        {
            string output = testAnimalGroup.GetHerd("RHINO");
            string expectedOutput = "Crash";
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void AnimalGroupTestUnknown()
        {
            string output = testAnimalGroup.GetHerd("??");
            string expectedOutput = "unknown";
            Assert.AreEqual(expectedOutput, output);
=======
        [TestMethod]
        public void TestMethod1()
        {
>>>>>>> a7f2bd226e9aba47b9b96c7403312c809d7f1352
        }
    }
}

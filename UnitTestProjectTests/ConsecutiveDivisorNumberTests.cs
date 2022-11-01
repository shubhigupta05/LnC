using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UnitTestProject.Tests
{
    [TestClass()]
    public class ConsecutiveDivisorNumberTests
    {
        ConsecutiveDivisorNumber divisorNumber = new ConsecutiveDivisorNumber();

        [TestMethod()]
        public void GetNumberOfDivisorTest_ExpectedOutput()
        {
            long divisorLimit = 2;
            var actual = divisorNumber.GetNumberOfDivisor(divisorLimit);
            var expected = new List<long> { 1, 2 };

            bool equalValues = Enumerable.SequenceEqual(expected, actual);
            Assert.IsTrue(equalValues);
        }

        [TestMethod()]
        public void ConsecutiveDivisorTest_ExpectedOutput()
        {
            long divisorLimit = 3;
            var actual = divisorNumber.ConsecutiveDivisor(divisorLimit);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
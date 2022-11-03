using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CalculatorUnitTests.MSTestTests
{
    [TestClass]
    public class SubMethodTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            calculator = new Calculator();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            calculator = null;
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(-1, 1, -2)]
        [DataRow(-5.2, 3.8, -9)]
        [DataRow(-5.2, "1", -6.2)]
        public void Sub_WhenCalled_ReturnsSubstraction(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Sub(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }
    }
}

using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CalculatorUnitTests.MSTestTests
{
    [TestClass]
    public class AddMethodTests
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
        [DataRow(1, 1, 2)]
        [DataRow(-5.2, "3.8", -1.4)]
        public void Add_WhenCalled_ReturnsAddition(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Add(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }
    }
}

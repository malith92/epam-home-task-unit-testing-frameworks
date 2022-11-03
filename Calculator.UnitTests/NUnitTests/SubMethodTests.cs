using System;
using CSharpCalculator;
using static CSharpCalculator.Calculator;
using NUnit.Framework;

namespace CalculatorUnitTests.NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SubMethodTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(-1, 1, -2)]
        [TestCase(-5.2, 3.7, -8.9)]
        [TestCase(-5.2, "3.8", -9)]
        public void Sub_WhenCalled_ReturnsSubstraction(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Sub(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }
    }
}

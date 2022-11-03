using System;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorUnitTests.NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AbsMethodTests
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
        [TestCase(1, 1)]
        [TestCase(-1, 1)]
        public void Abs_WhenCalled_ReturnsAddition(Object x, Object expected)
        {
            Assert.AreEqual(expected, calculator.Abs(x));
        }
    }
}

using System;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorUnitTests.NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AddMethodTests
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
        [TestCase(1, 1, 2)]
        [TestCase(-5.2, "3.8", -1.4)]
        public void Add_WhenCalled_ReturnsAddition(Object x, Object y, double expected)
        {
            Assert.AreEqual(expected, calculator.Add(Convert.ToDouble(x), Convert.ToDouble(y)), 1);
        }
    }
}

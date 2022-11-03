using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCalculator;

namespace CalculatorUnitTests.NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class DivideMethodTests
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
        [TestCase(10, 5, 2)]
        [TestCase(0, 10, 0)]
        [TestCase(1, 0, Double.PositiveInfinity)]
        public void Divide_WhenCalled_ReturnsDivide(double x, double y, double expected)
        {
            Assert.AreEqual(expected, calculator.Divide(x, y));
        }
    }
}

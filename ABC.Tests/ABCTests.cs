using NUnit.Framework;

namespace ABC.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc = null;

        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnSum()
        {
            var result = _calc.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [TestCase(10, 4, 6)]
        [TestCase(-2, -3, 1)]
        [TestCase(0, 5, -5)]
        public void Sub_ShouldReturnDifference(int a, int b, int expected)
        {
            var result = _calc.Sub(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

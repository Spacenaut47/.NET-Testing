using Products.Infrastructure;
using Xunit;

namespace Products.Infrastructure.Test
{
    public class CalculatorTests
    {
        private readonly ICalculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ReturnsSum()
        {
            Assert.Equal(7, _calculator.Add(3, 4));
        }

        [Fact]
        public void Sub_ReturnsDifference()
        {
            Assert.Equal(2, _calculator.Sub(5, 3));
        }

        [Fact]
        public void Mul_ReturnsProduct()
        {
            Assert.Equal(12, _calculator.Mul(3, 4));
        }

        [Fact]
        public void Div_ReturnsQuotient()
        {
            Assert.Equal(2, _calculator.Div(6, 3));
        }

        [Fact]
        public void Div_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Div(10, 0));
        }
    }
}

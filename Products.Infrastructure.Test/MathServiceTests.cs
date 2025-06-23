using Moq;
using Products.Infrastructure;
using Xunit;

namespace Products.Infrastructure.Test
{
    public class MathServiceTests
    {
        [Fact]
        public void DoubleAdd_CallsCalculatorAndReturnsDoubleResult()
        {
            // Arrange
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(c => c.Add(2, 3)).Returns(5);

            var service = new MathService(mockCalculator.Object);

            // Act
            var result = service.DoubleAdd(2, 3);

            // Assert
            Assert.Equal(10, result); // 2 * 5
            mockCalculator.Verify(c => c.Add(2, 3), Times.Once);
        }
    }
}

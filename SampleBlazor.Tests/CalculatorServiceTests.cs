using SampleBlazor.Services;
using Xunit;

namespace SampleBlazor.Tests
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectResult()
        {
            // Arrange
            var service = new CalculatorService();

            // Act
            var result = service.Add(5, 3);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
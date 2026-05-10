using Microsoft.Extensions.Logging;
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
            var logger = LoggerFactory
     .Create(builder => { })
     .CreateLogger<CalculatorService>();

            var service = new CalculatorService(logger);

            // Act
            var result = service.Add(5, 3);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
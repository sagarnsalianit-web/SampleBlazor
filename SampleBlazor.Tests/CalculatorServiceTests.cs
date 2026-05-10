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
        [Fact]
        public void Subtract_ShouldReturnCorrectResult()
        {
            var logger = LoggerFactory
                .Create(builder => { })
                .CreateLogger<CalculatorService>();

            var service = new CalculatorService(logger);

            var result = service.Subtract(10, 4);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectResult()
        {
            var logger = LoggerFactory
                .Create(builder => { })
                .CreateLogger<CalculatorService>();

            var service = new CalculatorService(logger);

            var result = service.Multiply(5, 4);

            Assert.Equal(20, result);
        }

        [Fact]
        public void IsEven_ShouldReturnTrue()
        {
            var logger = LoggerFactory
                .Create(builder => { })
                .CreateLogger<CalculatorService>();

            var service = new CalculatorService(logger);

            var result = service.IsEven(8);

            Assert.True(result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            var logger = LoggerFactory
                .Create(builder => { })
                .CreateLogger<CalculatorService>();

            var service = new CalculatorService(logger);

            Assert.Throws<DivideByZeroException>(() =>
            {
                service.Divide(10, 0);
            });
        }
    }
}
using Microsoft.Extensions.Logging;

namespace SampleBlazor.Services
{
    public class CalculatorService
    {
        private readonly ILogger<CalculatorService> _logger;

        public CalculatorService(ILogger<CalculatorService> logger)
        {
            _logger = logger;
        }

        public int Add(int a, int b)
        {
            _logger.LogInformation("Adding {A} and {B}", a, b);

            return a + b;
        }

        public int Subtract(int a, int b)
        {
            _logger.LogInformation("Subtracting {B} from {A}", b, a);

            return a - b;
        }

        public int Multiply(int a, int b)
        {
            _logger.LogInformation("Multiplying {A} and {B}", a, b);

            return a * b;
        }

        public double Divide(int a, int b)
        {
            _logger.LogInformation("Dividing {A} by {B}", a, b);

            if (b == 0)
            {
                _logger.LogError("Division by zero attempted");

                throw new DivideByZeroException("Cannot divide by zero");
            }

            return (double)a / b;
        }

        public bool IsEven(int number)
        {
            _logger.LogInformation("Checking whether {Number} is even", number);

            return number % 2 == 0;
        }
        public bool CheckValue(bool isValid)
        {
            if (isValid == true)
            {
                return true;
            }

            return false;
        }
    }
}
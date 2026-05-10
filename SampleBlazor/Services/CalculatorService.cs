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
            _logger.LogInformation("Add method called with values {A} and {B}", a, b);

            var result = a + b;

            _logger.LogInformation("Addition result is {Result}", result);

            return result;
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
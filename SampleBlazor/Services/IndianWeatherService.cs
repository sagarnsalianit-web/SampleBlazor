using Microsoft.Extensions.Logging;

namespace SampleBlazor.Services
{
    public class IndianWeatherService : IWeatherService
    {
        private readonly ILogger<IndianWeatherService> _logger;

        public IndianWeatherService(
            ILogger<IndianWeatherService> logger)
        {
            _logger = logger;
        }

        public string GetWeather(string city)
        {
            _logger.LogInformation(
                "Fetching weather for {City}", city);

            if (city == "Udupi")
            {
                return "30°C Sunny";
            }

            if (city == "Bangalore")
            {
                return "22°C Cloudy";
            }

            return "Weather data not available";
        }
    }
}

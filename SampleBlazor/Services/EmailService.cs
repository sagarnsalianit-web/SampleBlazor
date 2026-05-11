using Microsoft.Extensions.Logging;

namespace SampleBlazor.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;

        public EmailService(ILogger<EmailService> logger)
        {
            _logger = logger;
        }

        public string SendEmail(string to)
        {
            _logger.LogInformation("Sending email to {Email}", to);

            return $"Email successfully sent to {to}";
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdvancedConsoleApp
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _logger;
        private readonly IConfiguration _configuration;

        public GreetingService(ILogger<GreetingService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void Run()
        {
            for (int i = 0; i < _configuration.GetValue<int>("LoopTimes"); i++)
            {
                _logger.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}

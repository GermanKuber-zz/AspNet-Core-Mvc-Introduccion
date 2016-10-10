using Microsoft.Extensions.Configuration;

namespace AdminNetBaires.Services
{
    public class ConfigService : IConfigService
    {
        private readonly IConfiguration _configuration;
        private readonly string _saludo;

        public ConfigService(IConfiguration configuration)
        {
            _configuration = configuration;
            _saludo = $"{configuration["hello"]} - Pasando por mi servicio {nameof(ConfigService)}";
        }

        public string GetHello()
        {
            return _saludo;
        }
        public string GetDbConnectionString()
        {
            return _configuration["database:connection"];
        }
    }
}

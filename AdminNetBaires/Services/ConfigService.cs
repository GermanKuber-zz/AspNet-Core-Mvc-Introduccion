using Microsoft.Extensions.Configuration;

namespace AdminNetBaires.Services
{
    public class ConfigService : IConfigService
    {
        private readonly string _saludo;

        public ConfigService(IConfiguration configuration)
        {
            _saludo = $"{configuration["hello"]} - Pasando por mi servicio {nameof(ConfigService)}";
        }

        public string GetHello()
        {
            return _saludo;
        }
    }
}

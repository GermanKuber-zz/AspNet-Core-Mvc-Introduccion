using Microsoft.Extensions.Configuration;

namespace AdminNetBaires.Services
{
   

    //TODO : Paso 1 - Creo un servicio de configuracion
    public class ConfigService : IConfigService
    {
        private readonly string _greeting;

        public ConfigService(IConfiguration configuration)
        {
            _greeting = $"{configuration["hello"]} - Pasando por mi servicio {nameof(ConfigService)}";
        }

        public string GetHello()
        {
            return _greeting;
        }
    }
}

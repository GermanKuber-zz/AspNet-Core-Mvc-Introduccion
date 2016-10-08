using System.IO;
using AdminNetBaires.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AdminNetBaires
{
    public class Startup
    {

        public IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
          
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            //TODO : Paso 5 - Registro en mi contenedor mi nuevo servicio
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IConfigService, ConfigService>();
        }


        //TODO : Paso 3 - Inyecto mi servicio
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory,
            IConfigService configService)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                //TODO : Paso 4 - Utilizo el servicio para obtener la configuracion
                var saludo = configService.GetHello();
                await context.Response.WriteAsync(saludo);
            });
        }
    }
}

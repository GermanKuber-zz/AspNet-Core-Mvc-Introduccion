using System;
using System.IO;
using AdminNetBaires.Services;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using IApplicationBuilder = Microsoft.AspNetCore.Builder.IApplicationBuilder;

namespace AdminNetBaires
{
    public class Startup
    {
        //Todo : Paso 1 - Install-Package Microsoft.AspNet.Diagnostics
        public IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
          
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IConfigService, ConfigService>();
        }



        public void Configure(IApplicationBuilder app,
            //Todo : Paso 5 - Inyecto el servicio de Environment 
            //IHostingEnvironment env, 
            ILoggerFactory loggerFactory,
            IConfigService configService)
        {
            loggerFactory.AddConsole();


            //Todo : Paso 2 - Se genera pagina de Welcome
            //app.UseWelcomePage();

            //Todo : Paso 6 - Detecto si estoy en un Environment de Desarrollo
            //if (env.IsDevelopment())
            //{
            //Todo : Paso 4 - Habilito manejador
            //    app.UseDeveloperExceptionPage();
            //}

            //TODO : Paso 8 - Utilizo los archivos por defecto
            //app.UseDefaultFiles();
            //TODO : Paso 7 - Install-Package Microsoft.AspNetCore.StaticFiles
            //app.UseStaticFiles();

            //TODO : Paso 9 - Implementa los 2 metodos UseDefaultFiles y UseStaticFiles 
            //app.UseFileServer();
            app.Run(async (context) =>
            {
                //Todo : Paso 3 - Se Simula error
                throw  new Exception("Error !!!!!");
                var saludo = configService.GetHello();
                await context.Response.WriteAsync(saludo);
            });

            
        }
    }
}

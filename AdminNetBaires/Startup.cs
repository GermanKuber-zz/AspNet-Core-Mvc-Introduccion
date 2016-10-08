using System.IO;
using AdminNetBaires.Services;
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
        public IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
          
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            //TODO : Paso 5 - Agrego los servicios de Mvc
            //services.AddMvc();
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IConfigService, ConfigService>();
        }



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
         
            app.UseFileServer();

            //TODO : Paso 3 - Agrego el  middleware de Mvc
            //app.UseMvcWithDefaultRoute();


            //TODO : Paso 4 - Elimino el Index.html


            app.Run(async (context) =>
            {
                var saludo = configService.GetHello();
                await context.Response.WriteAsync(saludo);
            });
            //TODO : Paso 1 - Install-Package Microsoft.AspNetCore.Mvc

        }
    }
}

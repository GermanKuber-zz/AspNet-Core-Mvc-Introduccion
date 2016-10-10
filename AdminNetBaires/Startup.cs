﻿using System.IO;
using AdminNetBaires.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AdminNetBaires
{
    public class Startup
    {

        //TODO : Paso 1 - Instalo paquetes
        //Install-Package Microsoft.EntityFrameworkCore.Sqlite
        //Agrego Microsoft.EntityFrameworkCore.Design en el project.json
        //Agrego Microsoft.EntityFrameworkCore.Tools

        public IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            services.AddMvc();


            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IConfigService, ConfigService>();


            services.AddSingleton<IMembersService, MembersMemoryService>();
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

            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
                var saludo = configService.GetHello();
                await context.Response.WriteAsync(saludo);
            });

        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default",
                "{controller=Home}/{action=Index}/{id?}");
        }
    }
}

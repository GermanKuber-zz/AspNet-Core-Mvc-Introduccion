using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
        //TODO : Paso 1 - Agrego una variable donde guardar mi configuracion
        public IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            //TODO : Paso 2 - Leo el archivo de configuracion
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                //TODO : Paso 3 - Cargo la key de mi archivo de configuración
                var saludo = Configuration["hello"];
                await context.Response.WriteAsync(saludo);
            });
        }
    }
}

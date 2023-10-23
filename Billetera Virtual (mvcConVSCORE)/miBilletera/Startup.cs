using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;


namespace miBilletera
{     public class Startup
    {public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
   
        public IConfiguration Configuration { get; }//"http://localhost:4200"

        public void ConfigureServices(IServiceCollection services)
        {
/*services.AddCors(options =>
    {
        options.AddPolicy("MyAllowSpecificOrigins",
            builder =>
            {
                builder
                   // .WithOrigins("*")
                    .AllowAnyOrigin() // Aquí debes especificar las URLs permitidas http://localhost:4200/sesion
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
                builder
                    .WithOrigins("*") // Aquí debes especificar las URLs permitidas http://localhost:4200/sesion
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
    });*/
            services.AddControllers();

            // Agrega la configuración de Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mi API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Habilita CORS con la política configurada
            app.UseCors("MyAllowSpecificOrigins"); // Habilita CORS con la política configurada
            
            // Habilita Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}






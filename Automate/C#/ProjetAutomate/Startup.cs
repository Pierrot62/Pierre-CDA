using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProjetAutomate.Data;
using ProjetAutomate.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AutomateContext>(options => options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddTransient<Afpa_AnomaliesServices>();
            services.AddTransient<Afpa_CadencesServices>();
            services.AddTransient<Afpa_CouleursServices>();
            services.AddTransient<Afpa_ErreursServices>();
            services.AddTransient<Afpa_LumieresServices>();
            services.AddTransient<Afpa_SeuilsServices>();
            services.AddTransient<Afpa_SonsServices>();
            services.AddTransient<Afpa_TemperaturesServices>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjetAutomate", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy(name: "esquelbecq",
                                    builder =>
                                    {
                                        builder.WithOrigins("https://us-esquelbecq.fr/afpa/");
                                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjetAutomate v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("esquelbecq");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

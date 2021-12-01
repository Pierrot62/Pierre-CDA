using CrudApiPersonnes.Data.Models;
using CrudApiPersonnes.Data.Services;
using CrudApiPersonnes.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsUnitaires.Data
{
    class PersonneTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            services.AddDbContext<MyDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddTransient<PersonneServices>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CrudApiPersonnes", Version = "v1" });
            });
            Personne p = new Personne(1, "Toto", "Dupont", 21);
            PersonneServices.AddPersonne(p);
        }
    }
}
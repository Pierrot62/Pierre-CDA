using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personneapi.Data
{
    public class MyDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options) 
        {
        
        }
    }
}

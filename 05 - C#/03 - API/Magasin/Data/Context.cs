using Magasin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Data
{
    public class Context:DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produit>()
            .HasOne<Categorie>(p => p.CatProduit)
            .WithMany(c => c.ListProd)
            .HasForeignKey(p => p.IdCategorie);
        }
    }
}

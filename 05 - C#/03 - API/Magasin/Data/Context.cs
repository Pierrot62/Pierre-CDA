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
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Categorie> Categorie { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>(e2 =>
            {
                e2.ToTable("categories");
                e2.Property(e => e.IdCategorie).HasColumnName("idCategorie");
            });
            modelBuilder.Entity<Produit>(e1 =>
            {
                e1.ToTable("produits");
                e1.Property(e => e.IdCategorie).HasColumnName("idCategorie");
                e1.HasOne(e => e.CatProduit).WithOne().HasForeignKey<Categorie>(e => e.IdCategorie);
            });
        }
    }
}

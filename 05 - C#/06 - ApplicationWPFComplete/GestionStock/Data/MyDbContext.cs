using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using GestionStock.Data.Models;

#nullable disable

namespace GestionStock.Data
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<TypesProduit> TypesProduits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;database=gestionstock;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.IdArticle)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCategories, "FK_Articles_Categorie");

                entity.Property(e => e.IdArticle).HasColumnType("int(11)");

                entity.Property(e => e.IdCategories).HasColumnType("int(11)");

                entity.Property(e => e.LibelleArticle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuantiteStockee).HasColumnType("int(11)");

                entity.HasOne(d => d.IdCategoriesNavigation)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.IdCategories)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Articles_Categorie");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategories)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdTypesProduits, "FK_Categories_TypessProduits");

                entity.Property(e => e.IdCategories).HasColumnType("int(11)");

                entity.Property(e => e.IdTypesProduits).HasColumnType("int(11)");

                entity.Property(e => e.LibelleCategorie)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdTypesProduitsNavigation)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.IdTypesProduits)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categories_TypessProduits");
            });

            modelBuilder.Entity<TypesProduit>(entity =>
            {
                entity.HasKey(e => e.IdTypesProduits)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdTypesProduits).HasColumnType("int(11)");

                entity.Property(e => e.LibelleTypesProduit)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

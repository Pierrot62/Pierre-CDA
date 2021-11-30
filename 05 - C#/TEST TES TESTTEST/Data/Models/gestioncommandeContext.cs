using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TEST_TES_TESTTEST.Data.Models
{
    public partial class gestioncommandeContext : DbContext
    {
        public gestioncommandeContext()
        {
        }

        public gestioncommandeContext(DbContextOptions<gestioncommandeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Preparation> Preparations { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=ConnectionDBB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.IdCommande)
                    .HasName("PRIMARY");

                entity.ToTable("commandes");

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.DateCommande).HasColumnType("date");

                entity.Property(e => e.NumeroCommande).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Preparation>(entity =>
            {
                entity.HasKey(e => e.IdPreparation)
                    .HasName("PRIMARY");

                entity.ToTable("preparations");

                entity.HasIndex(e => e.IdCommande, "FK_Commandes_Preparatation");

                entity.HasIndex(e => e.IdProduit, "FK_Produits_Preparatation");

                entity.Property(e => e.IdPreparation).HasColumnType("int(11)");

                entity.Property(e => e.DatePreparation).HasColumnType("date");

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.HasOne(d => d.IdCommandeNavigation)
                    .WithMany(p => p.Preparations)
                    .HasForeignKey(d => d.IdCommande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Commandes_Preparatation");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.Preparations)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produits_Preparatation");
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.IdProduit)
                    .HasName("PRIMARY");

                entity.ToTable("produits");

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.Property(e => e.LibelleProduit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrixProduit).HasColumnType("decimal(15,2)");

                entity.Property(e => e.QuantiteProduit).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GestionAeroport.Data.Models
{
    public partial class AeroportContext : DbContext
    {

        public AeroportContext()
        {
        }

        public AeroportContext(DbContextOptions<AeroportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avion> Avions { get; set; }
        public virtual DbSet<Pilote> Pilotes { get; set; }
        public virtual DbSet<Trajet> Trajets { get; set; }
        public virtual DbSet<Vol> Vols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=ConnectionDBB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avion>(entity =>
            {
                entity.HasKey(e => e.IdAvion)
                    .HasName("PRIMARY");

                entity.ToTable("avions");

                entity.Property(e => e.IdAvion).HasColumnType("int(11)");

                entity.Property(e => e.Compagnie).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Pilote>(entity =>
            {
                entity.HasKey(e => e.IdPilote)
                    .HasName("PRIMARY");

                entity.ToTable("pilotes");

                entity.Property(e => e.IdPilote).HasColumnType("int(11)");

                entity.Property(e => e.Nom).HasMaxLength(100);

                entity.Property(e => e.Prenom).HasMaxLength(100);
            });

            modelBuilder.Entity<Trajet>(entity =>
            {
                entity.HasKey(e => e.IdTrajet)
                    .HasName("PRIMARY");

                entity.ToTable("trajets");

                entity.Property(e => e.IdTrajet).HasColumnType("int(11)");

                entity.Property(e => e.AeroportArrivee).HasMaxLength(200);

                entity.Property(e => e.AeroportDepart).HasMaxLength(200);
            });

            modelBuilder.Entity<Vol>(entity =>
            {
                entity.HasKey(e => e.IdVol)
                    .HasName("PRIMARY");

                entity.ToTable("vols");

                entity.HasIndex(e => e.IdAvion, "FK_Vols_Avions");

                entity.HasIndex(e => e.IdPilote, "FK_Vols_Pilotes");

                entity.HasIndex(e => e.IdTrajet, "FK_Vols_Trajets");

                entity.Property(e => e.IdVol).HasColumnType("int(11)");

                entity.Property(e => e.IdAvion).HasColumnType("int(11)");

                entity.Property(e => e.IdPilote).HasColumnType("int(11)");

                entity.Property(e => e.IdTrajet).HasColumnType("int(11)");

                entity.HasOne(d => d.IdAvionNavigation)
                    .WithMany(p => p.Vols)
                    .HasForeignKey(d => d.IdAvion)
                    .HasConstraintName("FK_Vols_Avions");

                entity.HasOne(d => d.IdPiloteNavigation)
                    .WithMany(p => p.Vols)
                    .HasForeignKey(d => d.IdPilote)
                    .HasConstraintName("FK_Vols_Pilotes");

                entity.HasOne(d => d.IdTrajetNavigation)
                    .WithMany(p => p.Vols)
                    .HasForeignKey(d => d.IdTrajet)
                    .HasConstraintName("FK_Vols_Trajets");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

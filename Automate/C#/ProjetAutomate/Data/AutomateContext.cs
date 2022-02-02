using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProjetAutomate.Data.Models;

#nullable disable

namespace ProjetAutomate.Data
{
    public partial class AutomateContext : DbContext
    {
        public AutomateContext()
        {
        }

        public AutomateContext(DbContextOptions<AutomateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Afpa_Anomalie> Afpa_Anomalies { get; set; }
        public virtual DbSet<Afpa_Couleur> Afpa_Couleurs { get; set; }
        public virtual DbSet<Afpa_Erreur> Afpa_Erreurs { get; set; }
        public virtual DbSet<Afpa_Lumiere> Afpa_Lumieres { get; set; }
        public virtual DbSet<Afpa_Seuil> Afpa_Seuils { get; set; }
        public virtual DbSet<Afpa_Son> Afpa_Sons { get; set; }
        public virtual DbSet<Afpa_Temperature> Afpa_Temperatures { get; set; }
        public virtual DbSet<Afpa_Cadence> Afpa_Cadences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Afpa_Anomalie>(entity =>
            {
                entity.HasKey(e => e.IdAnomalie)
                    .HasName("PRIMARY");

                entity.ToTable("afpa_anomalies");

                entity.HasIndex(e => e.IdErreur, "Afpa_Anomalies_Afpa_Erreurs");

                entity.Property(e => e.IdAnomalie).HasColumnType("int(11)");

                entity.Property(e => e.IdErreur).HasColumnType("int(11)");

                entity.Property(e => e.NbDeclasses).HasColumnType("int(11)");

                entity.Property(e => e.TypeAnomalie).HasMaxLength(50);

                entity.HasOne(d => d.Erreur)
                    .WithMany(p => p.AfpaAnomalies)
                    .HasForeignKey(d => d.IdErreur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Afpa_Anomalies_Afpa_Erreurs");
            });

            modelBuilder.Entity<Afpa_Cadence>(entity =>
            {
                entity.HasKey(e => e.IdCadence)
                    .HasName("PRIMARY");

                entity.ToTable("afpa_cadences");

                entity.Property(e => e.IdCadence).HasColumnType("int(11)");

                entity.Property(e => e.NbProduit).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Afpa_Couleur>(entity =>
            {
                entity.HasKey(e => e.IdCouleur)
                    .HasName("PRIMARY");

                entity.ToTable("afpa_couleurs");

                entity.Property(e => e.IdCouleur).HasColumnType("int(11)");

                entity.Property(e => e.Blue).HasColumnType("int(11)");

                entity.Property(e => e.Green).HasColumnType("int(11)");

                entity.Property(e => e.Red).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Afpa_Erreur>(entity =>
            {
                entity.HasKey(e => e.IdErreur)
                    .HasName("PRIMARY");

                entity.ToTable("afpa_erreurs");

                entity.Property(e => e.IdErreur).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Afpa_Lumiere>(entity =>
            {
                entity.HasKey(e => e.IdLumiere)
                    .HasName("PRIMARY");

                entity.ToTable("afpa_lumieres");

                entity.Property(e => e.IdLumiere).HasColumnType("int(11)");

            });

            //modelBuilder.Entity<Afpa_Objectif>(entity =>
            //{
            //    entity.HasKey(e => e.IdObjectif)
            //        .HasName("PRIMARY");

            //    entity.ToTable("afpa_objectifs");

            //    entity.Property(e => e.IdObjectif).HasColumnType("int(11)");

            //    entity.Property(e => e.MaxNombreArretDecibel).HasColumnType("int(11)");

            //    entity.Property(e => e.MaxNombreArretTemperature).HasColumnType("int(11)");

            //    entity.Property(e => e.MaxPourcentDeclasses).HasColumnType("int(11)");

            //    entity.Property(e => e.Rendement).HasColumnType("int(11)");
            //});

            modelBuilder.Entity<Afpa_Seuil>(entity =>
            {
                entity.HasKey(e => e.IdSeuil)
                    .HasName("PRIMARY");

                entity.ToTable("afpa_seuils");

                entity.Property(e => e.IdSeuil).HasColumnType("int(11)");

                entity.Property(e => e.DateSeuil).HasColumnType("date");

            });

            modelBuilder.Entity<Afpa_Son>(entity =>
            {
                entity.HasKey(e => e.IdSon)
                    .HasName("PRIMARY");

                entity.ToTable("afpa_sons");

                entity.Property(e => e.IdSon).HasColumnType("int(11)");

            });

            modelBuilder.Entity<Afpa_Temperature>(entity =>
            {
                entity.HasKey(e => e.IdTemperature)
                    .HasName("PRIMARY");

                entity.ToTable("afpa_temperatures");

                entity.Property(e => e.IdTemperature).HasColumnType("int(11)");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VetResource.Models
{
    public partial class VetResContext : DbContext
    {
        public VetResContext()
        {
        }

        public VetResContext(DbContextOptions<VetResContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<ResCont> ResCont { get; set; }
        public virtual DbSet<Vsocont> Vsocont { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=VS-MASTER\\SQLEXPRESS;Database=VetRes;integrated security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.FeedbackId)
                    .HasColumnName("Feedback ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FeedbackText)
                    .IsRequired()
                    .HasColumnName("Feedback Text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ResCont>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity.Property(e => e.ResourceId)
                    .HasColumnName("Resource ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.ContactInfo)
                    .HasColumnName("Contact Info")
                    .HasMaxLength(50);

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasColumnName("Resource Name")
                    .HasMaxLength(50);

                entity.Property(e => e.WebsiteUrl)
                    .IsRequired()
                    .HasColumnName("Website URL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vsocont>(entity =>
            {
                entity.HasKey(e => e.VsoId);

                entity.ToTable("VSOCont");

                entity.Property(e => e.VsoId)
                    .HasColumnName("VSO ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VsoAddress)
                    .IsRequired()
                    .HasColumnName("VSO Address")
                    .HasMaxLength(50);

                entity.Property(e => e.VsoContact)
                    .IsRequired()
                    .HasColumnName("VSO Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.VsoName)
                    .IsRequired()
                    .HasColumnName("VSO Name")
                    .HasMaxLength(50);

                entity.Property(e => e.VsoWebsite)
                    .IsRequired()
                    .HasColumnName("VSO Website")
                    .HasMaxLength(50);
            });
        }
    }
}

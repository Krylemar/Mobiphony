using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mobiphony.Models;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<CameraFeature> CameraFeatures { get; set; }

    public virtual DbSet<DisplayMatrix> DisplayMatrices { get; set; }

    public virtual DbSet<EfmigrationsHistory> EfmigrationsHistories { get; set; }

    public virtual DbSet<Feature> Features { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("Name=MySQLCloud");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<CameraFeature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("CameraFeature");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DisplayMatrix>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<EfmigrationsHistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__EFMigrationsHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Feature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.Brand, "BrandRelationship_idx");

            entity.HasIndex(e => e.Matrix, "PhoneMatrix_idx");

            entity.Property(e => e.Cpu).HasColumnName("CPU");
            entity.Property(e => e.Gpu).HasColumnName("GPU");
            entity.Property(e => e.Iprating).HasColumnName("IPRating");
            entity.Property(e => e.Os).HasColumnName("OS");
            entity.Property(e => e.Price).HasPrecision(10);
            entity.Property(e => e.Ram).HasColumnName("RAM");
            entity.Property(e => e.Sim).HasColumnName("SIM");
            entity.Property(e => e.Usbtype).HasColumnName("USBType");

            entity.HasOne(d => d.BrandNavigation).WithMany(p => p.Phones)
                .HasForeignKey(d => d.Brand)
                .HasConstraintName("BrandRelationship");

            entity.HasOne(d => d.MatrixNavigation).WithMany(p => p.Phones)
                .HasForeignKey(d => d.Matrix)
                .HasConstraintName("PhoneMatrix");

            entity.HasMany(d => d.CameraFeatures).WithMany(p => p.Phones)
                .UsingEntity<Dictionary<string, object>>(
                    "PhoneCameraFeature",
                    r => r.HasOne<CameraFeature>().WithMany()
                        .HasForeignKey("CameraFeatureId")
                        .HasConstraintName("FeatureRelationship"),
                    l => l.HasOne<Phone>().WithMany()
                        .HasForeignKey("PhoneId")
                        .HasConstraintName("PhoneRelationship"),
                    j =>
                    {
                        j.HasKey("PhoneId", "CameraFeatureId").HasName("PRIMARY");
                        j.ToTable("PhoneCameraFeature");
                        j.HasIndex(new[] { "CameraFeatureId" }, "FeatureRelationship_idx");
                    });

            entity.HasMany(d => d.Features).WithMany(p => p.Phones)
                .UsingEntity<Dictionary<string, object>>(
                    "PhoneFeature",
                    r => r.HasOne<Feature>().WithMany().HasForeignKey("FeatureId"),
                    l => l.HasOne<Phone>().WithMany().HasForeignKey("PhoneId"),
                    j =>
                    {
                        j.HasKey("PhoneId", "FeatureId").HasName("PRIMARY");
                        j.ToTable("PhoneFeature");
                        j.HasIndex(new[] { "FeatureId" }, "IX_PhoneFeature_FeatureId");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

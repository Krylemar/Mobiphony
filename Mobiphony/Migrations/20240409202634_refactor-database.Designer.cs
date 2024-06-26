﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mobiphony.Models;

#nullable disable

namespace Mobiphony.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240409202634_refactor-database")]
    partial class refactordatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mobiphony.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<sbyte>("BrandName")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Mobiphony.Models.DisplayMatrix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MatrixType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DisplayMatrices");
                });

            modelBuilder.Entity("Mobiphony.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Mobiphony.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BatCapacity")
                        .HasColumnType("int");

                    b.Property<int>("BatChargingWattage")
                        .HasColumnType("int");

                    b.Property<double>("BluetoothVersion")
                        .HasColumnType("double");

                    b.Property<int>("Brand")
                        .HasColumnType("int");

                    b.Property<double>("Brightness")
                        .HasColumnType("double");

                    b.Property<string>("CPU")
                        .HasColumnType("longtext");

                    b.Property<string>("Chipset")
                        .HasColumnType("longtext");

                    b.Property<double>("DisplaySize")
                        .HasColumnType("double");

                    b.Property<double>("ExpStorageLimit")
                        .HasColumnType("double");

                    b.Property<bool>("FaceRec")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FingerPrint")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("GPU")
                        .HasColumnType("longtext");

                    b.Property<int>("IPRating")
                        .HasColumnType("int");

                    b.Property<double>("InternalStorage")
                        .HasColumnType("double");

                    b.Property<double>("Length")
                        .HasColumnType("double");

                    b.Property<string>("MainCamFeatures")
                        .HasColumnType("longtext");

                    b.Property<double>("MainCamPhoto")
                        .HasColumnType("double");

                    b.Property<string>("MainCamVideo")
                        .HasColumnType("longtext");

                    b.Property<double>("Matrix")
                        .HasColumnType("double");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OS")
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("PurchaseLink")
                        .HasColumnType("longtext");

                    b.Property<int>("RAM")
                        .HasColumnType("int");

                    b.Property<double>("RefreshRate")
                        .HasColumnType("double");

                    b.Property<double>("Resolution")
                        .HasColumnType("double");

                    b.Property<string>("SCFeatures")
                        .HasColumnType("longtext");

                    b.Property<int>("SIM")
                        .HasColumnType("int");

                    b.Property<string>("ScreenProtection")
                        .HasColumnType("longtext");

                    b.Property<double>("SelfCamPhoto")
                        .HasColumnType("double");

                    b.Property<string>("SselfCamVideo")
                        .HasColumnType("longtext");

                    b.Property<double>("Thickness")
                        .HasColumnType("double");

                    b.Property<string>("USBType")
                        .HasColumnType("longtext");

                    b.Property<double>("WiFiSpeed")
                        .HasColumnType("double");

                    b.Property<double>("Width")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("Mobiphony.Models.PhoneFeature", b =>
                {
                    b.Property<int>("PhoneId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.HasKey("PhoneId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("PhoneFeature");
                });

            modelBuilder.Entity("Mobiphony.Models.PhoneFeature", b =>
                {
                    b.HasOne("Mobiphony.Models.Feature", "Feature")
                        .WithMany("PhoneFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobiphony.Models.Phone", "Phone")
                        .WithMany("Features")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("Mobiphony.Models.Feature", b =>
                {
                    b.Navigation("PhoneFeatures");
                });

            modelBuilder.Entity("Mobiphony.Models.Phone", b =>
                {
                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}

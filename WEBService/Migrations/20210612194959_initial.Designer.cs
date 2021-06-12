﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WEBService.Models;

namespace WEBService.Migrations
{
    [DbContext(typeof(WebServiceDBContext))]
    [Migration("20210612194959_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ElectricityMeasuringPointMeteringDevice", b =>
                {
                    b.Property<int>("ElectricityMeasuringPointsElectricityMeasuringPointId")
                        .HasColumnType("integer");

                    b.Property<int>("MeteringDevicesMeteringDeviceId")
                        .HasColumnType("integer");

                    b.HasKey("ElectricityMeasuringPointsElectricityMeasuringPointId", "MeteringDevicesMeteringDeviceId");

                    b.HasIndex("MeteringDevicesMeteringDeviceId");

                    b.ToTable("ElectricityMeasuringPointMeteringDevice");
                });

            modelBuilder.Entity("PointOfUseSupplyEndpoint", b =>
                {
                    b.Property<int>("PointsOfUsePointOfUseId")
                        .HasColumnType("integer");

                    b.Property<int>("SupplyEndpointsSupplyEndPointId")
                        .HasColumnType("integer");

                    b.HasKey("PointsOfUsePointOfUseId", "SupplyEndpointsSupplyEndPointId");

                    b.HasIndex("SupplyEndpointsSupplyEndPointId");

                    b.ToTable("PointOfUseSupplyEndpoint");
                });

            modelBuilder.Entity("WEBService.Models.CurrentTransformer", b =>
                {
                    b.Property<int>("CurrentTransformerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ElectricityMeasuringPointId")
                        .HasColumnType("integer");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<float>("TransformationRatio")
                        .HasColumnType("real");

                    b.Property<string>("TransformerType")
                        .HasColumnType("text");

                    b.HasKey("CurrentTransformerId");

                    b.HasIndex("ElectricityMeasuringPointId")
                        .IsUnique();

                    b.ToTable("CurrentTransformers");

                    b.HasData(
                        new
                        {
                            CurrentTransformerId = 1,
                            CheckDate = new DateTime(2021, 6, 12, 22, 49, 58, 881, DateTimeKind.Local).AddTicks(6945),
                            ElectricityMeasuringPointId = 1,
                            Number = "12AC",
                            TransformationRatio = 1.2f,
                            TransformerType = "C1"
                        });
                });

            modelBuilder.Entity("WEBService.Models.ElectricityMeasuringPoint", b =>
                {
                    b.Property<int>("ElectricityMeasuringPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PointOfUseId")
                        .HasColumnType("integer");

                    b.HasKey("ElectricityMeasuringPointId");

                    b.HasIndex("PointOfUseId");

                    b.ToTable("ElectricityMeasuringPoints");

                    b.HasData(
                        new
                        {
                            ElectricityMeasuringPointId = 1,
                            Name = "Point 1",
                            PointOfUseId = 1
                        });
                });

            modelBuilder.Entity("WEBService.Models.ElectricityMeter", b =>
                {
                    b.Property<int>("ElectricityMeterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ElectricityMeasuringPointId")
                        .HasColumnType("integer");

                    b.Property<string>("MeterType")
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.HasKey("ElectricityMeterId");

                    b.HasIndex("ElectricityMeasuringPointId")
                        .IsUnique();

                    b.ToTable("ElectricityMeters");

                    b.HasData(
                        new
                        {
                            ElectricityMeterId = 1,
                            CheckDate = new DateTime(2021, 6, 12, 22, 49, 58, 880, DateTimeKind.Local).AddTicks(8015),
                            ElectricityMeasuringPointId = 1,
                            MeterType = "V1",
                            Number = "12AB"
                        });
                });

            modelBuilder.Entity("WEBService.Models.MeteringDevice", b =>
                {
                    b.Property<int>("MeteringDeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("MeteringDeviceId");

                    b.ToTable("MeteringDevices");

                    b.HasData(
                        new
                        {
                            MeteringDeviceId = 1
                        });
                });

            modelBuilder.Entity("WEBService.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            OrganizationId = 1,
                            Address = "ул. 8 Марта 35",
                            Name = "Parent"
                        });
                });

            modelBuilder.Entity("WEBService.Models.PointOfUse", b =>
                {
                    b.Property<int>("PointOfUseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("SubsidiaryId")
                        .HasColumnType("integer");

                    b.HasKey("PointOfUseId");

                    b.HasIndex("SubsidiaryId");

                    b.ToTable("PointsOfUse");

                    b.HasData(
                        new
                        {
                            PointOfUseId = 1,
                            Address = "ул. Калинина 12",
                            Name = "Consumer",
                            SubsidiaryId = 1
                        });
                });

            modelBuilder.Entity("WEBService.Models.PotentialTransformer", b =>
                {
                    b.Property<int>("PotentialTransformerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ElectricityMeasuringPointId")
                        .HasColumnType("integer");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<float>("TransformationRatio")
                        .HasColumnType("real");

                    b.Property<string>("TransformerType")
                        .HasColumnType("text");

                    b.HasKey("PotentialTransformerId");

                    b.HasIndex("ElectricityMeasuringPointId")
                        .IsUnique();

                    b.ToTable("PotentialTransformers");

                    b.HasData(
                        new
                        {
                            PotentialTransformerId = 1,
                            CheckDate = new DateTime(2021, 6, 12, 22, 49, 58, 881, DateTimeKind.Local).AddTicks(8378),
                            ElectricityMeasuringPointId = 1,
                            Number = "12AD",
                            TransformationRatio = 1.8f,
                            TransformerType = "P1"
                        });
                });

            modelBuilder.Entity("WEBService.Models.Subsidiary", b =>
                {
                    b.Property<int>("SubsidiaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.HasKey("SubsidiaryId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Subsidiaries");

                    b.HasData(
                        new
                        {
                            SubsidiaryId = 1,
                            Address = "ул. Пушкина 12А",
                            Name = "Child",
                            OrganizationId = 1
                        });
                });

            modelBuilder.Entity("WEBService.Models.SupplyEndpoint", b =>
                {
                    b.Property<int>("SupplyEndPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<float>("MaxPower")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PointOfUseId")
                        .HasColumnType("integer");

                    b.HasKey("SupplyEndPointId");

                    b.ToTable("SupplyEndpoints");

                    b.HasData(
                        new
                        {
                            SupplyEndPointId = 1,
                            MaxPower = 12f,
                            Name = "EndPoint 1",
                            PointOfUseId = 1
                        });
                });

            modelBuilder.Entity("ElectricityMeasuringPointMeteringDevice", b =>
                {
                    b.HasOne("WEBService.Models.ElectricityMeasuringPoint", null)
                        .WithMany()
                        .HasForeignKey("ElectricityMeasuringPointsElectricityMeasuringPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBService.Models.MeteringDevice", null)
                        .WithMany()
                        .HasForeignKey("MeteringDevicesMeteringDeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PointOfUseSupplyEndpoint", b =>
                {
                    b.HasOne("WEBService.Models.PointOfUse", null)
                        .WithMany()
                        .HasForeignKey("PointsOfUsePointOfUseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBService.Models.SupplyEndpoint", null)
                        .WithMany()
                        .HasForeignKey("SupplyEndpointsSupplyEndPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WEBService.Models.CurrentTransformer", b =>
                {
                    b.HasOne("WEBService.Models.ElectricityMeasuringPoint", "ElectricityMeasuringPoint")
                        .WithOne("CurrentTransformer")
                        .HasForeignKey("WEBService.Models.CurrentTransformer", "ElectricityMeasuringPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricityMeasuringPoint");
                });

            modelBuilder.Entity("WEBService.Models.ElectricityMeasuringPoint", b =>
                {
                    b.HasOne("WEBService.Models.PointOfUse", "PointOfUse")
                        .WithMany("ElectricityMeasuringPoints")
                        .HasForeignKey("PointOfUseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PointOfUse");
                });

            modelBuilder.Entity("WEBService.Models.ElectricityMeter", b =>
                {
                    b.HasOne("WEBService.Models.ElectricityMeasuringPoint", "ElectricityMeasuringPoint")
                        .WithOne("ElectricityMeter")
                        .HasForeignKey("WEBService.Models.ElectricityMeter", "ElectricityMeasuringPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricityMeasuringPoint");
                });

            modelBuilder.Entity("WEBService.Models.PointOfUse", b =>
                {
                    b.HasOne("WEBService.Models.Subsidiary", "Subsidiary")
                        .WithMany("PointsOfUse")
                        .HasForeignKey("SubsidiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subsidiary");
                });

            modelBuilder.Entity("WEBService.Models.PotentialTransformer", b =>
                {
                    b.HasOne("WEBService.Models.ElectricityMeasuringPoint", "ElectricityMeasuringPoint")
                        .WithOne("PotentialTransformer")
                        .HasForeignKey("WEBService.Models.PotentialTransformer", "ElectricityMeasuringPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricityMeasuringPoint");
                });

            modelBuilder.Entity("WEBService.Models.Subsidiary", b =>
                {
                    b.HasOne("WEBService.Models.Organization", "Organization")
                        .WithMany("Subsidiaries")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("WEBService.Models.ElectricityMeasuringPoint", b =>
                {
                    b.Navigation("CurrentTransformer");

                    b.Navigation("ElectricityMeter");

                    b.Navigation("PotentialTransformer");
                });

            modelBuilder.Entity("WEBService.Models.Organization", b =>
                {
                    b.Navigation("Subsidiaries");
                });

            modelBuilder.Entity("WEBService.Models.PointOfUse", b =>
                {
                    b.Navigation("ElectricityMeasuringPoints");
                });

            modelBuilder.Entity("WEBService.Models.Subsidiary", b =>
                {
                    b.Navigation("PointsOfUse");
                });
#pragma warning restore 612, 618
        }
    }
}
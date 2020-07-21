﻿// <auto-generated />
using System;
using JemenaGasMeter.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JemenaGasMeter.WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200514161552_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("JemenaGasMeter.WebApi.DbModels.Depot", b =>
                {
                    b.Property<string>("DepotID")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Suburb")
                        .HasColumnType("TEXT");

                    b.HasKey("DepotID");

                    b.ToTable("Depots");
                });

            modelBuilder.Entity("JemenaGasMeter.WebApi.DbModels.Installation", b =>
                {
                    b.Property<int>("InstallationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MIRN")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Suburb")
                        .HasColumnType("TEXT");

                    b.HasKey("InstallationID");

                    b.ToTable("Installations");
                });

            modelBuilder.Entity("JemenaGasMeter.WebApi.DbModels.Meter", b =>
                {
                    b.Property<string>("MIRN")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpriyDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("MeterCondition")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MeterStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MeterType")
                        .HasColumnType("INTEGER");

                    b.HasKey("MIRN");

                    b.ToTable("Meters");
                });

            modelBuilder.Entity("JemenaGasMeter.WebApi.DbModels.MeterHistory", b =>
                {
                    b.Property<int>("MeterHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("MIRN")
                        .HasColumnType("TEXT");

                    b.Property<int>("MeterStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PayRollID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TransfereeID")
                        .HasColumnType("TEXT");

                    b.HasKey("MeterHistoryID");

                    b.HasIndex("MIRN");

                    b.HasIndex("PayRollID");

                    b.ToTable("MeterHistories");
                });

            modelBuilder.Entity("JemenaGasMeter.WebApi.DbModels.Transfer", b =>
                {
                    b.Property<int>("TransferID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TransferID");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("JemenaGasMeter.WebApi.DbModels.User", b =>
                {
                    b.Property<string>("PayRollID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PIN")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserType")
                        .HasColumnType("INTEGER");

                    b.HasKey("PayRollID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JemenaGasMeter.WebApi.DbModels.Warehouse", b =>
                {
                    b.Property<string>("WarehouseID")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Suburb")
                        .HasColumnType("TEXT");

                    b.HasKey("WarehouseID");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("JemenaGasMeter.WebApi.DbModels.MeterHistory", b =>
                {
                    b.HasOne("JemenaGasMeter.WebApi.DbModels.Meter", "Meter")
                        .WithMany("MeterHistories")
                        .HasForeignKey("MIRN");

                    b.HasOne("JemenaGasMeter.WebApi.DbModels.User", "User")
                        .WithMany("MeterHistories")
                        .HasForeignKey("PayRollID");
                });
#pragma warning restore 612, 618
        }
    }
}
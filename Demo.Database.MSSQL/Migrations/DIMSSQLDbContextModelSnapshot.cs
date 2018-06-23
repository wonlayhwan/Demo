﻿// <auto-generated />
using System;
using Demo.Database.MSSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.Database.MSSQL.Migrations
{
    [DbContext(typeof(DIMSSQLDbContext))]
    partial class DIMSSQLDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.Database.Schema.BasicLiving", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<double>("Amount");

                    b.Property<DateTime>("GainDate");

                    b.Property<string>("IdCardNumber")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("BasicLivings");
                });

            modelBuilder.Entity("Demo.Database.Schema.Car", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("CarBrand")
                        .HasMaxLength(80);

                    b.Property<string>("IdCardNumber")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Demo.Database.Schema.Communist", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("IdCardNumber")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.Property<int>("PartyStanding");

                    b.HasKey("Id");

                    b.ToTable("Communists");
                });

            modelBuilder.Entity("Demo.Database.Schema.GovernmentStaff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("IdCardNumber")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.Property<string>("Position")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("GovernmentStaffs");
                });

            modelBuilder.Entity("Demo.Database.Schema.Profile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("BornPlace")
                        .HasMaxLength(100);

                    b.Property<string>("IdCardNumber")
                        .HasMaxLength(30);

                    b.Property<string>("LivingPlace")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NorthwindLib;

namespace GameWorldWeb.Migrations
{
    [DbContext(typeof(Northwind))]
    partial class NorthwindModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("NorthwindLib.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("NorthwindLib.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("INTEGER");

                    b.Property<short?>("Popuplarity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<short?>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("NorthwindLib.Game", b =>
                {
                    b.HasOne("NorthwindLib.Company", "Company")
                        .WithMany("Games")
                        .HasForeignKey("CompanyID");
                });
#pragma warning restore 612, 618
        }
    }
}

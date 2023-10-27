﻿// <auto-generated />
using System;
using Drivers.api.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Drivers.api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Drivers.api.Models.Driver", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("bestPosition")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("bestPositionTimes")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("lastRace")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nationality")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("points")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("poles")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ranking")
                        .HasColumnType("INTEGER");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("team")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("teamPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("wins")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });
#pragma warning restore 612, 618
        }
    }
}

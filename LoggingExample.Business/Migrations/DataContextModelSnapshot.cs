﻿// <auto-generated />
using System;
using LoggingExample.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoggingExample.Business.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LoggingExample.Domain.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 5,
                            ReleaseDate = new DateTime(2001, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Shrek"
                        },
                        new
                        {
                            Id = 2,
                            Rating = 3,
                            ReleaseDate = new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            Id = 3,
                            Rating = 4,
                            ReleaseDate = new DateTime(1999, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 4,
                            Rating = 5,
                            ReleaseDate = new DateTime(1968, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Top Gun"
                        },
                        new
                        {
                            Id = 5,
                            Rating = 5,
                            ReleaseDate = new DateTime(2011, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Puss in Boots"
                        },
                        new
                        {
                            Id = 6,
                            Rating = 5,
                            ReleaseDate = new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Puss in Boots: The Last Wish"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

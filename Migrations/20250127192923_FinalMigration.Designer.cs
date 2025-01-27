﻿// <auto-generated />
using System;
using ChickenSoup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChickenSoup.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250127192923_FinalMigration")]
    partial class FinalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChickenSoup.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageCaption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Happy",
                            CreatedAt = new DateTime(2025, 1, 27, 13, 29, 23, 385, DateTimeKind.Local).AddTicks(200),
                            Description = "I saw some sunlight today and the weather is a bit warmer!",
                            ImageCaption = "",
                            ImagePath = "",
                            Name = "Generic Entry 1"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Sad",
                            CreatedAt = new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2100),
                            Description = "I found out the milk I've been drinking is expired...",
                            ImageCaption = "",
                            ImagePath = "",
                            Name = "Generic Entry 2"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Sample",
                            CreatedAt = new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2110),
                            Description = "This is a sample visual entry with an image.",
                            ImageCaption = "Saw him at San Diego Zoo",
                            ImagePath = "/images/panda.png",
                            Name = "Sample Visual Entry 1"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Sample",
                            CreatedAt = new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2380),
                            Description = "This is another sample visual entry with an image.",
                            ImageCaption = "I recently graduated",
                            ImagePath = "/images/grinnell.jpg",
                            Name = "Sample Visual Entry 2"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Sample",
                            CreatedAt = new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2380),
                            Description = "This is another sample visual entry with an image.",
                            ImageCaption = "The same breed as my dog!",
                            ImagePath = "/images/hmong-dog.jpg",
                            Name = "Sample Visual Entry 3"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Sample",
                            CreatedAt = new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2390),
                            Description = "This is another sample visual entry with an image.",
                            ImageCaption = "I'm so hungry~~",
                            ImagePath = "/images/sushi.jpg",
                            Name = "Sample Visual Entry 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

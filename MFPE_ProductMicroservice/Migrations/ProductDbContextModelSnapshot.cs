﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductMicroservices.ProductDbContext;

namespace MFPE_ProductMicroservice.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MFPE_ProductMicroservice.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is a brand new mobile phone",
                            Image_Name = "MobilePhone.jpg",
                            Name = "Mobile phone",
                            Price = 15000.0,
                            Rating = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is a brand new Pendrive",
                            Image_Name = "PenDrive.jpg",
                            Name = "Pendrive",
                            Price = 2000.0,
                            Rating = 3
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is a brand new HeadPhone",
                            Image_Name = "Headphone.jpg",
                            Name = "HeadPhones",
                            Price = 2000.0,
                            Rating = 4
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is a brand new Laptop",
                            Image_Name = "Laptop.jpg",
                            Name = "Laptop",
                            Price = 35000.0,
                            Rating = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

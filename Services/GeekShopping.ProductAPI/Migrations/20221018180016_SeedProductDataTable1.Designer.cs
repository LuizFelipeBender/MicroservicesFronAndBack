﻿// <auto-generated />
using GeekShopping.ProductAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MysqlContext))]
    [Migration("20221018180016_SeedProductDataTable1")]
    partial class SeedProductDataTable1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Product_Description");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Product_Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("Product_Price");

                    b.Property<string>("Product_Category_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Product_Category_Name");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1u,
                            Description = "Apple fruit",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg",
                            Name = "Apple",
                            Price = 12.29m,
                            Product_Category_Name = "Fruit"
                        },
                        new
                        {
                            Id = 2u,
                            Description = "Grape fruit",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg",
                            Name = "Grape",
                            Price = 3.29m,
                            Product_Category_Name = "Fruit"
                        },
                        new
                        {
                            Id = 3u,
                            Description = "Grape fruit",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg",
                            Name = "Grape",
                            Price = 3.29m,
                            Product_Category_Name = "Fruit"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

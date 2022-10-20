﻿// <auto-generated />
using System;
using GeekShopping.ProductAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MysqlContext))]
    partial class MysqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.ProductAPI+Brand", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<string>("picture")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.ProductAPI+Gpc", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("code")
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Gpcs");
                });

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.ProductAPI+Ncm", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("code")
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("full_description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Ncms");
                });

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.ProductAPI+ProductJson", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<double>("avg_price")
                        .HasColumnType("double");

                    b.Property<uint?>("brandId")
                        .HasColumnType("int unsigned");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<uint?>("gpcId")
                        .HasColumnType("int unsigned");

                    b.Property<int>("gross_weight")
                        .HasColumnType("int");

                    b.Property<long>("gtin")
                        .HasColumnType("bigint");

                    b.Property<double>("height")
                        .HasColumnType("double");

                    b.Property<double>("length")
                        .HasColumnType("double");

                    b.Property<double>("max_price")
                        .HasColumnType("double");

                    b.Property<uint?>("ncmId")
                        .HasColumnType("int unsigned");

                    b.Property<int>("net_weight")
                        .HasColumnType("int");

                    b.Property<string>("price")
                        .HasColumnType("longtext");

                    b.Property<string>("thumbnail")
                        .HasColumnType("longtext");

                    b.Property<double>("width")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("brandId");

                    b.HasIndex("gpcId");

                    b.HasIndex("ncmId");

                    b.ToTable("ProductJsons");
                });

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.ProductAPI+ProductJson", b =>
                {
                    b.HasOne("GeekShopping.ProductAPI.Model.ProductAPI+Brand", "brand")
                        .WithMany()
                        .HasForeignKey("brandId");

                    b.HasOne("GeekShopping.ProductAPI.Model.ProductAPI+Gpc", "gpc")
                        .WithMany()
                        .HasForeignKey("gpcId");

                    b.HasOne("GeekShopping.ProductAPI.Model.ProductAPI+Ncm", "ncm")
                        .WithMany()
                        .HasForeignKey("ncmId");

                    b.Navigation("brand");

                    b.Navigation("gpc");

                    b.Navigation("ncm");
                });
#pragma warning restore 612, 618
        }
    }
}

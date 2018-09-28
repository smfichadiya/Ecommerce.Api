﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Streetwood.Core.Domain.Implementation;

namespace Streetwood.Core.Migrations
{
    [DbContext(typeof(StreetwoodContext))]
    [Migration("20180928134702_AddedRefreshToken")]
    partial class AddedRefreshToken
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country");

                    b.Property<string>("PostCode")
                        .HasMaxLength(8);

                    b.Property<string>("Street")
                        .HasMaxLength(50);

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Charm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CharmCategoryId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("NameEng");

                    b.Property<decimal>("Price");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CharmCategoryId");

                    b.ToTable("Charms");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.CharmCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CharmCategories");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsMain");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ClosedDateTime");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsClosed");

                    b.Property<bool>("IsPayed");

                    b.Property<bool>("IsShipped");

                    b.Property<Guid?>("OrderDiscountId");

                    b.Property<DateTime?>("PayedDateTime");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("PriceWithShippment");

                    b.Property<DateTime?>("ShippmentDateTime");

                    b.Property<Guid?>("ShippmentdId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderDiscountId");

                    b.HasIndex("ShippmentdId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.OrderDiscount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AvaibleFrom");

                    b.Property<DateTime>("AvaibleTo");

                    b.Property<string>("Description");

                    b.Property<string>("DescriptionEng");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<string>("NameEng")
                        .HasMaxLength(30);

                    b.Property<decimal>("PercentValue");

                    b.HasKey("Id");

                    b.ToTable("OrderDiscounts");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcceptCharms");

                    b.Property<string>("Description");

                    b.Property<string>("DescriptionEng");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("NameEng")
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.Property<Guid?>("ProductCategoryId");

                    b.Property<string>("Sizes")
                        .HasMaxLength(50);

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoryId");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<Guid?>("ProductCategoryDiscountId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductCategoryDiscountId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.ProductCategoryDiscount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AvaibleFrom");

                    b.Property<DateTime>("AvaibleTo");

                    b.Property<string>("Description");

                    b.Property<string>("DescriptionEng");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<string>("NameEng")
                        .HasMaxLength(30);

                    b.Property<decimal>("PercentValue");

                    b.HasKey("Id");

                    b.ToTable("ProductCategoryDiscounts");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.ProductOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("Comment");

                    b.Property<decimal>("CurrentProductPrice");

                    b.Property<Guid?>("OrderId");

                    b.Property<Guid?>("ProductCategoryDiscountId");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductCategoryDiscountId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.ProductOrderCharm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CharmId");

                    b.Property<decimal>("CurrentPrice");

                    b.Property<Guid?>("ProductOrderId");

                    b.HasKey("Id");

                    b.HasIndex("CharmId");

                    b.HasIndex("ProductOrderId");

                    b.ToTable("ProductOrderCharms");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Shippment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("DescriptionEng");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("NameEng")
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Shippments");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChangePasswordToken");

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasMaxLength(40);

                    b.Property<string>("PasswordHash");

                    b.Property<int>("PhoneNumber");

                    b.Property<string>("RefreshToken");

                    b.Property<string>("Salt");

                    b.Property<int>("Type");

                    b.Property<int>("UserStatus");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Address", b =>
                {
                    b.HasOne("Streetwood.Core.Domain.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Charm", b =>
                {
                    b.HasOne("Streetwood.Core.Domain.Entities.CharmCategory", "CharmCategory")
                        .WithMany("Charms")
                        .HasForeignKey("CharmCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Image", b =>
                {
                    b.HasOne("Streetwood.Core.Domain.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Order", b =>
                {
                    b.HasOne("Streetwood.Core.Domain.Entities.OrderDiscount", "OrderDiscount")
                        .WithMany("Orders")
                        .HasForeignKey("OrderDiscountId");

                    b.HasOne("Streetwood.Core.Domain.Entities.Shippment", "Shippment")
                        .WithMany("Orders")
                        .HasForeignKey("ShippmentdId");

                    b.HasOne("Streetwood.Core.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.Product", b =>
                {
                    b.HasOne("Streetwood.Core.Domain.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("Streetwood.Core.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Streetwood.Core.Domain.Entities.ProductCategoryDiscount", "ProductCategoryDiscount")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductCategoryDiscountId");
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.ProductOrder", b =>
                {
                    b.HasOne("Streetwood.Core.Domain.Entities.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Streetwood.Core.Domain.Entities.ProductCategoryDiscount", "ProductCategoryDiscount")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductCategoryDiscountId");

                    b.HasOne("Streetwood.Core.Domain.Entities.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Streetwood.Core.Domain.Entities.ProductOrderCharm", b =>
                {
                    b.HasOne("Streetwood.Core.Domain.Entities.Charm", "Charm")
                        .WithMany("ProductOrderCharms")
                        .HasForeignKey("CharmId");

                    b.HasOne("Streetwood.Core.Domain.Entities.ProductOrder", "ProductOrder")
                        .WithMany("ProductOrderCharms")
                        .HasForeignKey("ProductOrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
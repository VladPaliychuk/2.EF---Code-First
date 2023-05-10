﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesDAL.Data;

#nullable disable

namespace SalesDAL.Migrations
{
    [DbContext(typeof(SalesContext))]
    partial class SalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesDAL.Data.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CreditCardNumber = "670694539254285941",
                            Email = "Demond.Sawayn@hotmail.com",
                            Name = "Rylan"
                        },
                        new
                        {
                            CustomerId = 2,
                            CreditCardNumber = "3498-458407-41795",
                            Email = "Marcia15@gmail.com",
                            Name = "Fanny"
                        },
                        new
                        {
                            CustomerId = 3,
                            CreditCardNumber = "5512-4525-6886-0764",
                            Email = "Roderick69@yahoo.com",
                            Name = "Janelle"
                        },
                        new
                        {
                            CustomerId = 4,
                            CreditCardNumber = "4376-3320-5613-5028",
                            Email = "Kaley.Rohan54@gmail.com",
                            Name = "Maverick"
                        },
                        new
                        {
                            CustomerId = 5,
                            CreditCardNumber = "6771-8971-5043-3004",
                            Email = "Domenico.Cummings95@yahoo.com",
                            Name = "Rosalinda"
                        },
                        new
                        {
                            CustomerId = 6,
                            CreditCardNumber = "4258-2643-1733-8286",
                            Email = "Floy_Homenick16@yahoo.com",
                            Name = "Melisa"
                        },
                        new
                        {
                            CustomerId = 7,
                            CreditCardNumber = "3486-179146-41982",
                            Email = "Russel_Veum@yahoo.com",
                            Name = "Vanessa"
                        },
                        new
                        {
                            CustomerId = 8,
                            CreditCardNumber = "63047291288950742",
                            Email = "Hope47@hotmail.com",
                            Name = "Ramon"
                        },
                        new
                        {
                            CustomerId = 9,
                            CreditCardNumber = "3487-258173-13938",
                            Email = "Sydney_MacGyver@yahoo.com",
                            Name = "Anibal"
                        },
                        new
                        {
                            CustomerId = 10,
                            CreditCardNumber = "6398-9961-4820-3850",
                            Email = "Kole.Berge@yahoo.com",
                            Name = "Lesly"
                        });
                });

            modelBuilder.Entity("SalesDAL.Data.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasDefaultValue("No description");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Name = "Incredible Cotton Towels",
                            Price = 1911,
                            Quantity = 4
                        },
                        new
                        {
                            ProductId = 2,
                            Name = "Incredible Granite Chair",
                            Price = 1330,
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 3,
                            Name = "Sleek Plastic Gloves",
                            Price = 542,
                            Quantity = 9
                        },
                        new
                        {
                            ProductId = 4,
                            Name = "Ergonomic Concrete Mouse",
                            Price = 1209,
                            Quantity = 10
                        },
                        new
                        {
                            ProductId = 5,
                            Name = "Rustic Wooden Cheese",
                            Price = 1203,
                            Quantity = 7
                        },
                        new
                        {
                            ProductId = 6,
                            Name = "Licensed Fresh Soap",
                            Price = 1198,
                            Quantity = 3
                        },
                        new
                        {
                            ProductId = 7,
                            Name = "Awesome Steel Bike",
                            Price = 1379,
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 8,
                            Name = "Sleek Concrete Chips",
                            Price = 1973,
                            Quantity = 10
                        },
                        new
                        {
                            ProductId = 9,
                            Name = "Unbranded Soft Sausages",
                            Price = 517,
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 10,
                            Name = "Refined Steel Mouse",
                            Price = 1137,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("SalesDAL.Data.Entities.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("SaleId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SaleId = 1,
                            CustomerId = 1,
                            Date = new DateTime(2022, 8, 19, 5, 40, 38, 254, DateTimeKind.Local).AddTicks(2482),
                            ProductId = 1,
                            StoreId = 8
                        },
                        new
                        {
                            SaleId = 2,
                            CustomerId = 8,
                            Date = new DateTime(2023, 2, 7, 21, 56, 44, 832, DateTimeKind.Local).AddTicks(4751),
                            ProductId = 4,
                            StoreId = 3
                        },
                        new
                        {
                            SaleId = 3,
                            CustomerId = 2,
                            Date = new DateTime(2022, 12, 29, 6, 32, 25, 435, DateTimeKind.Local).AddTicks(7096),
                            ProductId = 10,
                            StoreId = 2
                        },
                        new
                        {
                            SaleId = 4,
                            CustomerId = 3,
                            Date = new DateTime(2022, 8, 27, 0, 50, 10, 65, DateTimeKind.Local).AddTicks(1390),
                            ProductId = 4,
                            StoreId = 6
                        },
                        new
                        {
                            SaleId = 5,
                            CustomerId = 5,
                            Date = new DateTime(2022, 11, 27, 5, 11, 20, 788, DateTimeKind.Local).AddTicks(1546),
                            ProductId = 10,
                            StoreId = 7
                        },
                        new
                        {
                            SaleId = 6,
                            CustomerId = 1,
                            Date = new DateTime(2022, 7, 6, 19, 29, 30, 957, DateTimeKind.Local).AddTicks(3541),
                            ProductId = 8,
                            StoreId = 2
                        },
                        new
                        {
                            SaleId = 7,
                            CustomerId = 4,
                            Date = new DateTime(2022, 6, 30, 14, 19, 19, 99, DateTimeKind.Local).AddTicks(6034),
                            ProductId = 4,
                            StoreId = 10
                        },
                        new
                        {
                            SaleId = 8,
                            CustomerId = 7,
                            Date = new DateTime(2023, 3, 28, 16, 35, 23, 918, DateTimeKind.Local).AddTicks(3083),
                            ProductId = 3,
                            StoreId = 5
                        },
                        new
                        {
                            SaleId = 9,
                            CustomerId = 2,
                            Date = new DateTime(2023, 2, 26, 12, 56, 51, 900, DateTimeKind.Local).AddTicks(6946),
                            ProductId = 2,
                            StoreId = 7
                        },
                        new
                        {
                            SaleId = 10,
                            CustomerId = 7,
                            Date = new DateTime(2023, 3, 30, 2, 22, 23, 758, DateTimeKind.Local).AddTicks(5781),
                            ProductId = 7,
                            StoreId = 4
                        });
                });

            modelBuilder.Entity("SalesDAL.Data.Entities.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<string>("Name")
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            StoreId = 1,
                            Name = "Streich LLC"
                        },
                        new
                        {
                            StoreId = 2,
                            Name = "Willms - Reichert"
                        },
                        new
                        {
                            StoreId = 3,
                            Name = "Stamm, Boyle and Konopelski"
                        },
                        new
                        {
                            StoreId = 4,
                            Name = "Lockman Group"
                        },
                        new
                        {
                            StoreId = 5,
                            Name = "Willms - Satterfield"
                        },
                        new
                        {
                            StoreId = 6,
                            Name = "Bosco and Sons"
                        },
                        new
                        {
                            StoreId = 7,
                            Name = "Lueilwitz, Zboncak and Klocko"
                        },
                        new
                        {
                            StoreId = 8,
                            Name = "Cummings Inc"
                        },
                        new
                        {
                            StoreId = 9,
                            Name = "Daugherty, Satterfield and Feil"
                        },
                        new
                        {
                            StoreId = 10,
                            Name = "Kuvalis LLC"
                        });
                });

            modelBuilder.Entity("SalesDAL.Data.Entities.Sale", b =>
                {
                    b.HasOne("SalesDAL.Data.Entities.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesDAL.Data.Entities.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesDAL.Data.Entities.Store", "Store")
                        .WithMany("Sales")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("SalesDAL.Data.Entities.Customer", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SalesDAL.Data.Entities.Product", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SalesDAL.Data.Entities.Store", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
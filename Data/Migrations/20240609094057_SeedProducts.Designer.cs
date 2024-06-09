﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(PmsDbContext))]
    [Migration("20240609094057_SeedProducts")]
    partial class SeedProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Models.ErrorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<DateTime>("Time")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2024, 5, 31, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2578),
                            IsActive = true,
                            Name = "IPhone 15 Pro Max 512GB",
                            Price = 2999.9899999999998
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2024, 6, 4, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2587),
                            IsActive = false,
                            Name = "Samsung Galaxy S23 Ultra 256GB",
                            Price = 1399.99
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(2024, 5, 28, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2589),
                            IsActive = true,
                            Name = "Google Pixel 7 Pro 128GB",
                            Price = 999.99000000000001
                        },
                        new
                        {
                            Id = 4,
                            DateAdded = new DateTime(2024, 5, 22, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2592),
                            IsActive = false,
                            Name = "Sony Bravia 65\" 4K TV",
                            Price = 1499.99
                        },
                        new
                        {
                            Id = 5,
                            DateAdded = new DateTime(2024, 5, 15, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2594),
                            IsActive = true,
                            Name = "Bose QuietComfort 35 II Headphones",
                            Price = 299.99000000000001
                        },
                        new
                        {
                            Id = 6,
                            DateAdded = new DateTime(2024, 5, 24, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2597),
                            IsActive = true,
                            Name = "Apple MacBook Pro 16\" 1TB",
                            Price = 2499.9899999999998
                        },
                        new
                        {
                            Id = 7,
                            DateAdded = new DateTime(2024, 5, 13, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2598),
                            IsActive = false,
                            Name = "Samsung Galaxy Tab S8 256GB",
                            Price = 799.99000000000001
                        },
                        new
                        {
                            Id = 8,
                            DateAdded = new DateTime(2024, 5, 21, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2600),
                            IsActive = false,
                            Name = "Canon EOS R5 Mirrorless Camera",
                            Price = 3899.9899999999998
                        },
                        new
                        {
                            Id = 9,
                            DateAdded = new DateTime(2024, 5, 26, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2601),
                            IsActive = false,
                            Name = "Sony WH-1000XM4 Wireless Headphones",
                            Price = 349.99000000000001
                        },
                        new
                        {
                            Id = 10,
                            DateAdded = new DateTime(2024, 5, 19, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2604),
                            IsActive = false,
                            Name = "Microsoft Surface Laptop 4 512GB",
                            Price = 1599.99
                        },
                        new
                        {
                            Id = 11,
                            DateAdded = new DateTime(2024, 5, 28, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2605),
                            IsActive = true,
                            Name = "Dell XPS 13 1TB",
                            Price = 1899.99
                        },
                        new
                        {
                            Id = 12,
                            DateAdded = new DateTime(2024, 6, 3, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2607),
                            IsActive = true,
                            Name = "Amazon Echo Show 10",
                            Price = 249.99000000000001
                        },
                        new
                        {
                            Id = 13,
                            DateAdded = new DateTime(2024, 5, 14, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2608),
                            IsActive = false,
                            Name = "GoPro HERO9 Black",
                            Price = 399.99000000000001
                        },
                        new
                        {
                            Id = 14,
                            DateAdded = new DateTime(2024, 6, 6, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2610),
                            IsActive = true,
                            Name = "Apple Watch Series 7",
                            Price = 499.99000000000001
                        },
                        new
                        {
                            Id = 15,
                            DateAdded = new DateTime(2024, 5, 12, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2611),
                            IsActive = true,
                            Name = "HP Envy 6055 All-in-One Printer",
                            Price = 129.99000000000001
                        },
                        new
                        {
                            Id = 16,
                            DateAdded = new DateTime(2024, 6, 4, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2612),
                            IsActive = false,
                            Name = "LG 27\" 4K UltraFine Monitor",
                            Price = 699.99000000000001
                        },
                        new
                        {
                            Id = 17,
                            DateAdded = new DateTime(2024, 5, 28, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2615),
                            IsActive = false,
                            Name = "Fitbit Charge 5",
                            Price = 179.99000000000001
                        },
                        new
                        {
                            Id = 18,
                            DateAdded = new DateTime(2024, 5, 11, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2617),
                            IsActive = false,
                            Name = "Nintendo Switch OLED Model",
                            Price = 349.99000000000001
                        },
                        new
                        {
                            Id = 19,
                            DateAdded = new DateTime(2024, 5, 20, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2618),
                            IsActive = true,
                            Name = "DJI Mavic Air 2 Drone",
                            Price = 799.99000000000001
                        },
                        new
                        {
                            Id = 20,
                            DateAdded = new DateTime(2024, 5, 11, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2620),
                            IsActive = false,
                            Name = "JBL Flip 5 Bluetooth Speaker",
                            Price = 119.98999999999999
                        },
                        new
                        {
                            Id = 21,
                            DateAdded = new DateTime(2024, 5, 12, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2621),
                            IsActive = true,
                            Name = "Apple AirPods Pro",
                            Price = 249.99000000000001
                        },
                        new
                        {
                            Id = 22,
                            DateAdded = new DateTime(2024, 5, 23, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2623),
                            IsActive = true,
                            Name = "Razer Blade 15 Gaming Laptop",
                            Price = 2199.9899999999998
                        },
                        new
                        {
                            Id = 23,
                            DateAdded = new DateTime(2024, 5, 18, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2624),
                            IsActive = true,
                            Name = "Logitech MX Master 3 Mouse",
                            Price = 99.989999999999995
                        },
                        new
                        {
                            Id = 24,
                            DateAdded = new DateTime(2024, 5, 27, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2626),
                            IsActive = true,
                            Name = "Sony PlayStation 5",
                            Price = 499.99000000000001
                        },
                        new
                        {
                            Id = 25,
                            DateAdded = new DateTime(2024, 5, 13, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2627),
                            IsActive = false,
                            Name = "Xbox Series X",
                            Price = 499.99000000000001
                        },
                        new
                        {
                            Id = 26,
                            DateAdded = new DateTime(2024, 5, 21, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2628),
                            IsActive = true,
                            Name = "Samsung Galaxy Watch 4",
                            Price = 249.99000000000001
                        },
                        new
                        {
                            Id = 27,
                            DateAdded = new DateTime(2024, 5, 14, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2630),
                            IsActive = false,
                            Name = "Garmin Forerunner 945",
                            Price = 599.99000000000001
                        },
                        new
                        {
                            Id = 28,
                            DateAdded = new DateTime(2024, 5, 12, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2631),
                            IsActive = false,
                            Name = "Acer Predator Helios 300 Gaming Laptop",
                            Price = 1499.99
                        },
                        new
                        {
                            Id = 29,
                            DateAdded = new DateTime(2024, 6, 1, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2633),
                            IsActive = true,
                            Name = "LG Gram 17\" Laptop 1TB",
                            Price = 1699.99
                        },
                        new
                        {
                            Id = 30,
                            DateAdded = new DateTime(2024, 5, 27, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2635),
                            IsActive = true,
                            Name = "Apple iPad Pro 12.9\" 256GB",
                            Price = 1099.99
                        },
                        new
                        {
                            Id = 31,
                            DateAdded = new DateTime(2024, 5, 26, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2636),
                            IsActive = false,
                            Name = "Sony Alpha a7 III Mirrorless Camera",
                            Price = 1999.99
                        },
                        new
                        {
                            Id = 32,
                            DateAdded = new DateTime(2024, 5, 29, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2638),
                            IsActive = false,
                            Name = "Nikon Z6 II Mirrorless Camera",
                            Price = 1799.99
                        },
                        new
                        {
                            Id = 33,
                            DateAdded = new DateTime(2024, 5, 19, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2639),
                            IsActive = false,
                            Name = "Canon PowerShot G7 X Mark III",
                            Price = 749.99000000000001
                        },
                        new
                        {
                            Id = 34,
                            DateAdded = new DateTime(2024, 6, 1, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2642),
                            IsActive = false,
                            Name = "Fujifilm X-T4 Mirrorless Camera",
                            Price = 1699.99
                        },
                        new
                        {
                            Id = 35,
                            DateAdded = new DateTime(2024, 5, 12, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2643),
                            IsActive = false,
                            Name = "Panasonic Lumix GH5",
                            Price = 1399.99
                        },
                        new
                        {
                            Id = 36,
                            DateAdded = new DateTime(2024, 5, 19, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2644),
                            IsActive = false,
                            Name = "Olympus OM-D E-M1 Mark III",
                            Price = 1799.99
                        },
                        new
                        {
                            Id = 37,
                            DateAdded = new DateTime(2024, 5, 29, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2646),
                            IsActive = false,
                            Name = "Sony RX100 VII",
                            Price = 1299.99
                        },
                        new
                        {
                            Id = 38,
                            DateAdded = new DateTime(2024, 5, 14, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2648),
                            IsActive = false,
                            Name = "GoPro MAX",
                            Price = 499.99000000000001
                        },
                        new
                        {
                            Id = 39,
                            DateAdded = new DateTime(2024, 5, 23, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2649),
                            IsActive = false,
                            Name = "DJI Osmo Action",
                            Price = 329.99000000000001
                        },
                        new
                        {
                            Id = 40,
                            DateAdded = new DateTime(2024, 5, 23, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2651),
                            IsActive = true,
                            Name = "Insta360 ONE R Twin Edition",
                            Price = 479.99000000000001
                        },
                        new
                        {
                            Id = 41,
                            DateAdded = new DateTime(2024, 5, 25, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2652),
                            IsActive = true,
                            Name = "Microsoft Surface Pro 7",
                            Price = 899.99000000000001
                        },
                        new
                        {
                            Id = 42,
                            DateAdded = new DateTime(2024, 6, 5, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2654),
                            IsActive = false,
                            Name = "Apple Mac Mini M1",
                            Price = 699.99000000000001
                        },
                        new
                        {
                            Id = 43,
                            DateAdded = new DateTime(2024, 5, 11, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2656),
                            IsActive = false,
                            Name = "HP Spectre x360 14",
                            Price = 1599.99
                        },
                        new
                        {
                            Id = 44,
                            DateAdded = new DateTime(2024, 5, 11, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2658),
                            IsActive = true,
                            Name = "Asus ZenBook Duo 14",
                            Price = 1299.99
                        },
                        new
                        {
                            Id = 45,
                            DateAdded = new DateTime(2024, 5, 21, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2659),
                            IsActive = true,
                            Name = "Lenovo ThinkPad X1 Carbon",
                            Price = 1799.99
                        },
                        new
                        {
                            Id = 46,
                            DateAdded = new DateTime(2024, 6, 3, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2661),
                            IsActive = true,
                            Name = "Acer Swift 3",
                            Price = 699.99000000000001
                        },
                        new
                        {
                            Id = 47,
                            DateAdded = new DateTime(2024, 5, 15, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2663),
                            IsActive = true,
                            Name = "Razer Book 13",
                            Price = 1499.99
                        },
                        new
                        {
                            Id = 48,
                            DateAdded = new DateTime(2024, 5, 19, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2665),
                            IsActive = true,
                            Name = "Dell Inspiron 15 7000",
                            Price = 899.99000000000001
                        },
                        new
                        {
                            Id = 49,
                            DateAdded = new DateTime(2024, 5, 22, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2667),
                            IsActive = true,
                            Name = "MSI Stealth 15M",
                            Price = 1399.99
                        },
                        new
                        {
                            Id = 50,
                            DateAdded = new DateTime(2024, 5, 20, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2668),
                            IsActive = true,
                            Name = "Gigabyte Aero 15",
                            Price = 1799.99
                        });
                });

            modelBuilder.Entity("Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

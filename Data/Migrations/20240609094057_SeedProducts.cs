using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateAdded", "IsActive", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 31, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2578), true, "IPhone 15 Pro Max 512GB", 2999.9899999999998 },
                    { 2, new DateTime(2024, 6, 4, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2587), false, "Samsung Galaxy S23 Ultra 256GB", 1399.99 },
                    { 3, new DateTime(2024, 5, 28, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2589), true, "Google Pixel 7 Pro 128GB", 999.99000000000001 },
                    { 4, new DateTime(2024, 5, 22, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2592), false, "Sony Bravia 65\" 4K TV", 1499.99 },
                    { 5, new DateTime(2024, 5, 15, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2594), true, "Bose QuietComfort 35 II Headphones", 299.99000000000001 },
                    { 6, new DateTime(2024, 5, 24, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2597), true, "Apple MacBook Pro 16\" 1TB", 2499.9899999999998 },
                    { 7, new DateTime(2024, 5, 13, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2598), false, "Samsung Galaxy Tab S8 256GB", 799.99000000000001 },
                    { 8, new DateTime(2024, 5, 21, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2600), false, "Canon EOS R5 Mirrorless Camera", 3899.9899999999998 },
                    { 9, new DateTime(2024, 5, 26, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2601), false, "Sony WH-1000XM4 Wireless Headphones", 349.99000000000001 },
                    { 10, new DateTime(2024, 5, 19, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2604), false, "Microsoft Surface Laptop 4 512GB", 1599.99 },
                    { 11, new DateTime(2024, 5, 28, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2605), true, "Dell XPS 13 1TB", 1899.99 },
                    { 12, new DateTime(2024, 6, 3, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2607), true, "Amazon Echo Show 10", 249.99000000000001 },
                    { 13, new DateTime(2024, 5, 14, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2608), false, "GoPro HERO9 Black", 399.99000000000001 },
                    { 14, new DateTime(2024, 6, 6, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2610), true, "Apple Watch Series 7", 499.99000000000001 },
                    { 15, new DateTime(2024, 5, 12, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2611), true, "HP Envy 6055 All-in-One Printer", 129.99000000000001 },
                    { 16, new DateTime(2024, 6, 4, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2612), false, "LG 27\" 4K UltraFine Monitor", 699.99000000000001 },
                    { 17, new DateTime(2024, 5, 28, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2615), false, "Fitbit Charge 5", 179.99000000000001 },
                    { 18, new DateTime(2024, 5, 11, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2617), false, "Nintendo Switch OLED Model", 349.99000000000001 },
                    { 19, new DateTime(2024, 5, 20, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2618), true, "DJI Mavic Air 2 Drone", 799.99000000000001 },
                    { 20, new DateTime(2024, 5, 11, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2620), false, "JBL Flip 5 Bluetooth Speaker", 119.98999999999999 },
                    { 21, new DateTime(2024, 5, 12, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2621), true, "Apple AirPods Pro", 249.99000000000001 },
                    { 22, new DateTime(2024, 5, 23, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2623), true, "Razer Blade 15 Gaming Laptop", 2199.9899999999998 },
                    { 23, new DateTime(2024, 5, 18, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2624), true, "Logitech MX Master 3 Mouse", 99.989999999999995 },
                    { 24, new DateTime(2024, 5, 27, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2626), true, "Sony PlayStation 5", 499.99000000000001 },
                    { 25, new DateTime(2024, 5, 13, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2627), false, "Xbox Series X", 499.99000000000001 },
                    { 26, new DateTime(2024, 5, 21, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2628), true, "Samsung Galaxy Watch 4", 249.99000000000001 },
                    { 27, new DateTime(2024, 5, 14, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2630), false, "Garmin Forerunner 945", 599.99000000000001 },
                    { 28, new DateTime(2024, 5, 12, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2631), false, "Acer Predator Helios 300 Gaming Laptop", 1499.99 },
                    { 29, new DateTime(2024, 6, 1, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2633), true, "LG Gram 17\" Laptop 1TB", 1699.99 },
                    { 30, new DateTime(2024, 5, 27, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2635), true, "Apple iPad Pro 12.9\" 256GB", 1099.99 },
                    { 31, new DateTime(2024, 5, 26, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2636), false, "Sony Alpha a7 III Mirrorless Camera", 1999.99 },
                    { 32, new DateTime(2024, 5, 29, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2638), false, "Nikon Z6 II Mirrorless Camera", 1799.99 },
                    { 33, new DateTime(2024, 5, 19, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2639), false, "Canon PowerShot G7 X Mark III", 749.99000000000001 },
                    { 34, new DateTime(2024, 6, 1, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2642), false, "Fujifilm X-T4 Mirrorless Camera", 1699.99 },
                    { 35, new DateTime(2024, 5, 12, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2643), false, "Panasonic Lumix GH5", 1399.99 },
                    { 36, new DateTime(2024, 5, 19, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2644), false, "Olympus OM-D E-M1 Mark III", 1799.99 },
                    { 37, new DateTime(2024, 5, 29, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2646), false, "Sony RX100 VII", 1299.99 },
                    { 38, new DateTime(2024, 5, 14, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2648), false, "GoPro MAX", 499.99000000000001 },
                    { 39, new DateTime(2024, 5, 23, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2649), false, "DJI Osmo Action", 329.99000000000001 },
                    { 40, new DateTime(2024, 5, 23, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2651), true, "Insta360 ONE R Twin Edition", 479.99000000000001 },
                    { 41, new DateTime(2024, 5, 25, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2652), true, "Microsoft Surface Pro 7", 899.99000000000001 },
                    { 42, new DateTime(2024, 6, 5, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2654), false, "Apple Mac Mini M1", 699.99000000000001 },
                    { 43, new DateTime(2024, 5, 11, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2656), false, "HP Spectre x360 14", 1599.99 },
                    { 44, new DateTime(2024, 5, 11, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2658), true, "Asus ZenBook Duo 14", 1299.99 },
                    { 45, new DateTime(2024, 5, 21, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2659), true, "Lenovo ThinkPad X1 Carbon", 1799.99 },
                    { 46, new DateTime(2024, 6, 3, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2661), true, "Acer Swift 3", 699.99000000000001 },
                    { 47, new DateTime(2024, 5, 15, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2663), true, "Razer Book 13", 1499.99 },
                    { 48, new DateTime(2024, 5, 19, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2665), true, "Dell Inspiron 15 7000", 899.99000000000001 },
                    { 49, new DateTime(2024, 5, 22, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2667), true, "MSI Stealth 15M", 1399.99 },
                    { 50, new DateTime(2024, 5, 20, 9, 40, 55, 432, DateTimeKind.Utc).AddTicks(2668), true, "Gigabyte Aero 15", 1799.99 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}

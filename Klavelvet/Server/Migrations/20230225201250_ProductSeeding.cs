using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Klavelvet.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("154c3480-4b7e-413a-b5c9-12708d472ddf"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image3.jpg", 19.99m, "Lorem ipsum lingerie 5" },
                    { new Guid("20f77013-dd95-4b9c-87f4-018d2c894a86"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image1.jpg", 49.99m, "Lorem ipsum corset 3" },
                    { new Guid("243383bb-5cb0-48bc-909b-316405792731"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image4.jpg", 29.99m, "Lorem ipsum lingerie 4" },
                    { new Guid("28c156a8-103a-4fe5-92e7-f76015802257"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image2.jpg", 69.99m, "Lorem ipsum corset 2" },
                    { new Guid("32a4f616-c953-44f1-944d-2e375632b2ee"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image4.jpg", 29.99m, "Lorem ipsum lingerie 2" },
                    { new Guid("64ce47e8-28c3-4386-89dc-7d4a4912677c"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image1.jpg", 49.99m, "Lorem ipsum corset 1" },
                    { new Guid("6d8fc9d1-b598-4015-b3cf-e74bf95b1218"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image2.jpg", 69.99m, "Lorem ipsum corset 4" },
                    { new Guid("7d850c3c-91e8-4f02-a534-a1f68af066c7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image1.jpg", 49.99m, "Lorem ipsum corset 5" },
                    { new Guid("8a613382-5e9f-4958-a1f9-aef56594118d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image3.jpg", 19.99m, "Lorem ipsum lingerie 1" },
                    { new Guid("a4cfb645-90a2-40ba-a4b6-48e06653360b"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image3.jpg", 19.99m, "Lorem ipsum lingerie 3" },
                    { new Guid("c64c4158-6eaf-4a5e-bc4a-743b3fb7a3b9"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image2.jpg", 69.99m, "Lorem ipsum corset 6" },
                    { new Guid("fedcee37-7b89-4b5b-a7fb-434dbd6fdd97"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image4.jpg", 29.99m, "Lorem ipsum lingerie 6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("154c3480-4b7e-413a-b5c9-12708d472ddf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20f77013-dd95-4b9c-87f4-018d2c894a86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("243383bb-5cb0-48bc-909b-316405792731"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28c156a8-103a-4fe5-92e7-f76015802257"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32a4f616-c953-44f1-944d-2e375632b2ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64ce47e8-28c3-4386-89dc-7d4a4912677c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d8fc9d1-b598-4015-b3cf-e74bf95b1218"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d850c3c-91e8-4f02-a534-a1f68af066c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a613382-5e9f-4958-a1f9-aef56594118d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4cfb645-90a2-40ba-a4b6-48e06653360b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c64c4158-6eaf-4a5e-bc4a-743b3fb7a3b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fedcee37-7b89-4b5b-a7fb-434dbd6fdd97"));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Klavelvet.Server.Migrations
{
    /// <inheritdoc />
    public partial class Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Corsets", "corsets" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Lingerie", "lingerie" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Accesories", "accesories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("3f979837-3c04-4e7c-93e7-dc9859849a2e"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image4.jpg", 29.99m, "Lorem ipsum lingerie 4" },
                    { new Guid("551a22c8-fc6d-48ff-a5dd-53d21064c2bb"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image2.jpg", 69.99m, "Lorem ipsum bracelet 2" },
                    { new Guid("8c3ea00a-11db-4233-9f0c-8a366292496d"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image1.jpg", 49.99m, "Lorem ipsum corset 3" },
                    { new Guid("92a7d3b0-2567-41c9-9e85-57f34ec65f39"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image4.jpg", 29.99m, "Lorem ipsum lingerie 2" },
                    { new Guid("9a4026dd-41d2-493e-ba83-073a52221d45"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image2.jpg", 69.99m, "Lorem ipsum corset 2" },
                    { new Guid("9c244d0b-dc50-4dc5-914e-847330fa8a26"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image3.jpg", 19.99m, "Lorem ipsum bracelet 3" },
                    { new Guid("9e4b4f0d-f0c1-4446-9254-48b7c03ff3fd"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image2.jpg", 69.99m, "Lorem ipsum corset 4" },
                    { new Guid("ccbfa31d-3715-4764-ba17-527e46cecf58"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "https://example.com/image4.jpg", 29.99m, "Lorem ipsum bracelet 4" },
                    { new Guid("d07a754c-1b45-467b-ba97-99180439e911"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image1.jpg", 49.99m, "Lorem ipsum corset 1" },
                    { new Guid("d90c170e-9920-4486-a470-ddad31b0e75d"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image3.jpg", 19.99m, "Lorem ipsum lingerie 3" },
                    { new Guid("ef8fad09-669d-4a09-98b1-9523b6c2c683"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image3.jpg", 19.99m, "Lorem ipsum lingerie 1" },
                    { new Guid("fe6e4acb-0f75-43d1-936e-3ccce573a832"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://example.com/image1.jpg", 49.99m, "Lorem ipsum bracelet 1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f979837-3c04-4e7c-93e7-dc9859849a2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("551a22c8-fc6d-48ff-a5dd-53d21064c2bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c3ea00a-11db-4233-9f0c-8a366292496d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92a7d3b0-2567-41c9-9e85-57f34ec65f39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a4026dd-41d2-493e-ba83-073a52221d45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c244d0b-dc50-4dc5-914e-847330fa8a26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e4b4f0d-f0c1-4446-9254-48b7c03ff3fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccbfa31d-3715-4764-ba17-527e46cecf58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d07a754c-1b45-467b-ba97-99180439e911"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d90c170e-9920-4486-a470-ddad31b0e75d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef8fad09-669d-4a09-98b1-9523b6c2c683"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe6e4acb-0f75-43d1-936e-3ccce573a832"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

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
    }
}

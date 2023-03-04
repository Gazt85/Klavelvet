using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Klavelvet.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("3b9b19a7-3d59-499c-8d1b-94fa1b1cf8a8"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "/images/products/no-photo-placeholder.png", 29.99m, "Lorem ipsum bracelet 4" },
                    { new Guid("5cc1a1e7-8f22-42cd-b62e-22ddb1554772"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "/images/products/accesories/bracelet_1.png", 49.99m, "Lorem ipsum bracelet 1" },
                    { new Guid("640f3165-8940-4768-82c9-9629873cb1a9"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "/images/products/no-photo-placeholder.png", 69.99m, "Lorem ipsum bracelet 2" },
                    { new Guid("6a063e94-37a5-4019-be3d-664dd453afa9"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "/images/products/no-photo-placeholder.png", 69.99m, "Lorem ipsum corset 4" },
                    { new Guid("7d5a1144-d392-49d5-be2e-d926f553901f"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "/images/products/61+xvxreiyl._ac_ul1001_.jpg", 49.99m, "Lorem ipsum corset 3" },
                    { new Guid("843b31fa-e860-4ca9-9b74-42cff6ac4bc7"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "/images/products/no-photo-placeholder.png", 19.99m, "Lorem ipsum bracelet 3" },
                    { new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "/images/products/no-photo-placeholder.png", 29.99m, "Lorem ipsum lingerie 4" },
                    { new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "/images/products/no-photo-placeholder.png", 19.99m, "Lorem ipsum lingerie 1" },
                    { new Guid("a1da89c8-9d11-4808-aec3-e25a3117d29c"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "https://upload.wikimedia.org/wikipedia/commons/0/01/Corset1878taille46_300gram.png", 49.99m, "Lorem ipsum corset 1" },
                    { new Guid("d9433ebc-3715-4157-8edc-25e3502527e2"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "/images/products/no-photo-placeholder.png", 29.99m, "Lorem ipsum lingerie 2" },
                    { new Guid("df5b6339-e65b-488f-b837-b7434445ce54"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in massa purus. Fusce eleifend ullamcorper diam, vel dictum velit auctor vitae. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent ultrices dolor sit amet lorem posuere, eget rhoncus ipsum euismod.", "/images/products/no-photo-placeholder.png", 19.99m, "Lorem ipsum lingerie 3" },
                    { new Guid("fec703b8-d206-408f-ade9-0b0c338ea98b"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique auctor nibh vel venenatis. Praesent consequat, erat vitae venenatis volutpat, justo dolor imperdiet ipsum, vel euismod mi odio a dolor. Donec iaculis, ante ac tempor accumsan, urna nisi lacinia justo, sed lobortis orci odio ac augue.", "/images/products/71vhl6wsxcl._ac_ul400_.jpg", 69.99m, "Lorem ipsum corset 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b9b19a7-3d59-499c-8d1b-94fa1b1cf8a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cc1a1e7-8f22-42cd-b62e-22ddb1554772"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("640f3165-8940-4768-82c9-9629873cb1a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a063e94-37a5-4019-be3d-664dd453afa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d5a1144-d392-49d5-be2e-d926f553901f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("843b31fa-e860-4ca9-9b74-42cff6ac4bc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1da89c8-9d11-4808-aec3-e25a3117d29c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9433ebc-3715-4157-8edc-25e3502527e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df5b6339-e65b-488f-b837-b7434445ce54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fec703b8-d206-408f-ade9-0b0c338ea98b"));

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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Klavelvet.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductVariants2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Dresses", "dresses" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unique Size" },
                    { 2, "Size XS" },
                    { 3, "Size S" },
                    { 4, "Size M" },
                    { 5, "Size L" },
                    { 6, "Size XL" },
                    { 7, "Size XXL" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"),
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "/images/products/dresses/dress_4.jpg", "Lorem ipsum dress 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"),
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "/images/products/dresses/dress_1.jpg", "Lorem ipsum dress 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9433ebc-3715-4157-8edc-25e3502527e2"),
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "/images/products/dresses/dress_2.jpg", "Lorem ipsum dress 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df5b6339-e65b-488f-b837-b7434445ce54"),
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "/images/products/dresses/dress_3.jpg", "Lorem ipsum dress 3" });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("3b9b19a7-3d59-499c-8d1b-94fa1b1cf8a8"), 1, 39.99m, 29.99m },
                    { new Guid("5cc1a1e7-8f22-42cd-b62e-22ddb1554772"), 1, 59.99m, 49.99m },
                    { new Guid("640f3165-8940-4768-82c9-9629873cb1a9"), 1, 39.99m, 29.99m },
                    { new Guid("6a063e94-37a5-4019-be3d-664dd453afa9"), 3, 49.99m, 29.99m },
                    { new Guid("6a063e94-37a5-4019-be3d-664dd453afa9"), 4, 49.99m, 29.99m },
                    { new Guid("6a063e94-37a5-4019-be3d-664dd453afa9"), 5, 49.99m, 29.99m },
                    { new Guid("7d5a1144-d392-49d5-be2e-d926f553901f"), 2, 59.99m, 59.99m },
                    { new Guid("7d5a1144-d392-49d5-be2e-d926f553901f"), 4, 59.99m, 79.99m },
                    { new Guid("7d5a1144-d392-49d5-be2e-d926f553901f"), 5, 59.99m, 59.99m },
                    { new Guid("7d5a1144-d392-49d5-be2e-d926f553901f"), 6, 59.99m, 59.99m },
                    { new Guid("843b31fa-e860-4ca9-9b74-42cff6ac4bc7"), 1, 29.99m, 29.99m },
                    { new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"), 2, 79.99m, 49.99m },
                    { new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"), 3, 79.99m, 49.99m },
                    { new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"), 4, 79.99m, 49.99m },
                    { new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"), 5, 79.99m, 49.99m },
                    { new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"), 6, 79.99m, 49.99m },
                    { new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"), 7, 79.99m, 49.99m },
                    { new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"), 2, 69.99m, 69.99m },
                    { new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"), 3, 69.99m, 69.99m },
                    { new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"), 4, 69.99m, 69.99m },
                    { new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"), 5, 79.99m, 69.99m },
                    { new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"), 6, 79.99m, 69.99m },
                    { new Guid("a1da89c8-9d11-4808-aec3-e25a3117d29c"), 3, 79.99m, 79.99m },
                    { new Guid("a1da89c8-9d11-4808-aec3-e25a3117d29c"), 4, 79.99m, 89.99m },
                    { new Guid("a1da89c8-9d11-4808-aec3-e25a3117d29c"), 5, 79.99m, 89.99m },
                    { new Guid("a1da89c8-9d11-4808-aec3-e25a3117d29c"), 6, 79.99m, 69.99m },
                    { new Guid("a1da89c8-9d11-4808-aec3-e25a3117d29c"), 7, 79.99m, 79.99m },
                    { new Guid("d9433ebc-3715-4157-8edc-25e3502527e2"), 2, 59.99m, 49.99m },
                    { new Guid("d9433ebc-3715-4157-8edc-25e3502527e2"), 3, 59.99m, 49.99m },
                    { new Guid("d9433ebc-3715-4157-8edc-25e3502527e2"), 4, 59.99m, 49.99m },
                    { new Guid("d9433ebc-3715-4157-8edc-25e3502527e2"), 5, 59.99m, 49.99m },
                    { new Guid("df5b6339-e65b-488f-b837-b7434445ce54"), 3, 79.99m, 69.99m },
                    { new Guid("df5b6339-e65b-488f-b837-b7434445ce54"), 6, 79.99m, 79.99m },
                    { new Guid("fec703b8-d206-408f-ade9-0b0c338ea98b"), 2, 59.99m, 49.99m },
                    { new Guid("fec703b8-d206-408f-ade9-0b0c338ea98b"), 3, 59.99m, 49.99m },
                    { new Guid("fec703b8-d206-408f-ade9-0b0c338ea98b"), 4, 59.99m, 49.99m },
                    { new Guid("fec703b8-d206-408f-ade9-0b0c338ea98b"), 5, 59.99m, 9.99m },
                    { new Guid("fec703b8-d206-408f-ade9-0b0c338ea98b"), 6, 59.99m, 49.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Lingerie", "lingerie" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b9b19a7-3d59-499c-8d1b-94fa1b1cf8a8"),
                column: "Price",
                value: 29.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cc1a1e7-8f22-42cd-b62e-22ddb1554772"),
                column: "Price",
                value: 49.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("640f3165-8940-4768-82c9-9629873cb1a9"),
                column: "Price",
                value: 69.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a063e94-37a5-4019-be3d-664dd453afa9"),
                column: "Price",
                value: 69.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d5a1144-d392-49d5-be2e-d926f553901f"),
                column: "Price",
                value: 49.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("843b31fa-e860-4ca9-9b74-42cff6ac4bc7"),
                column: "Price",
                value: 19.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a9f0aca-829a-49ba-834f-fb7c67bb3f14"),
                columns: new[] { "ImageURL", "Price", "Title" },
                values: new object[] { "/images/products/no-photo-placeholder.png", 29.99m, "Lorem ipsum lingerie 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fd60b55-ab68-46bb-a683-9dcf766c5612"),
                columns: new[] { "ImageURL", "Price", "Title" },
                values: new object[] { "/images/products/no-photo-placeholder.png", 19.99m, "Lorem ipsum lingerie 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1da89c8-9d11-4808-aec3-e25a3117d29c"),
                column: "Price",
                value: 49.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9433ebc-3715-4157-8edc-25e3502527e2"),
                columns: new[] { "ImageURL", "Price", "Title" },
                values: new object[] { "/images/products/no-photo-placeholder.png", 29.99m, "Lorem ipsum lingerie 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df5b6339-e65b-488f-b837-b7434445ce54"),
                columns: new[] { "ImageURL", "Price", "Title" },
                values: new object[] { "/images/products/no-photo-placeholder.png", 19.99m, "Lorem ipsum lingerie 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fec703b8-d206-408f-ade9-0b0c338ea98b"),
                column: "Price",
                value: 69.99m);
        }
    }
}

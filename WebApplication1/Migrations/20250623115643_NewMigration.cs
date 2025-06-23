using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Kane Miller" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Sam Raiden" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "Jana McLeaf" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "CategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("19d76285-08df-4bc1-98bf-266b730cea1f"), "Author- 3", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 3" },
                    { new Guid("334b2729-702d-4721-a984-60e8f2c61a3d"), "Author- 11", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 11" },
                    { new Guid("3d59a3b4-73d4-43e5-b545-6761a12017a1"), "Author- 15", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 15" },
                    { new Guid("5719c352-00af-43a9-a9c7-67a3ed9aa2e7"), "Author- 10", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 10" },
                    { new Guid("6bc7696e-289c-4bfb-8025-6d3addb93bb0"), "Author- 18", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 18" },
                    { new Guid("6e28194f-3354-4024-9e97-ea29641b92b3"), "Author- 4", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 4" },
                    { new Guid("6fa2ee0f-f3e2-49e7-a83f-f980ed6d0ce0"), "Author- 2", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 2" },
                    { new Guid("7219c927-5396-4aaf-99a9-945c068ab6bb"), "Author- 8", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 8" },
                    { new Guid("9028b685-33c9-4a22-b008-6f2ded3434da"), "Author- 1", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 1" },
                    { new Guid("9787fd26-7268-4ff2-80db-83a8bed73dbd"), "Author- 7", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 7" },
                    { new Guid("b01bffa4-093a-44ca-9b10-60f47f3ae2c2"), "Author- 12", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 12" },
                    { new Guid("b17832c9-6cbd-483e-b83c-04c269c42cb1"), "Author- 14", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 14" },
                    { new Guid("b182db71-c172-4e6d-bf3a-327d23ddeb14"), "Author- 19", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 19" },
                    { new Guid("b88e6610-64f4-434e-8ee5-a2a9d7e3a511"), "Author- 13", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 13" },
                    { new Guid("ba244aab-4906-4c23-ba23-1bd793f2eaf2"), "Author- 9", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 9" },
                    { new Guid("bf9822df-3461-4f33-85ca-8289b886acf0"), "Author- 17", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 17" },
                    { new Guid("cdc3fb58-7482-4c95-896d-286774a99a23"), "Author- 16", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 16" },
                    { new Guid("dd596d44-eeb0-48e2-8d51-21814e453e88"), "Author- 6", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 6" },
                    { new Guid("f41e7c5e-120c-4cbf-b81f-ebdc303aa41e"), "Author- 5", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 5" },
                    { new Guid("ff76db7c-0b0a-497a-8229-49f263ec8e33"), "Author- 20", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 20" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

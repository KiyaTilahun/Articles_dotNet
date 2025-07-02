using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class New_Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("00c9f8b2-cb32-46e3-94c8-6d66b985dccd"), new DateTime(2000, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 18" },
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kane Miller" },
                    { new Guid("03975dbc-1bb5-43d2-842a-6327c94c987c"), new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 31" },
                    { new Guid("07df5a07-98f1-44f5-9285-74e8d5fdbc75"), new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 19" },
                    { new Guid("0b512a6e-6ff0-45bc-bcb1-8e782bd05cee"), new DateTime(2000, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 26" },
                    { new Guid("1a5cd1c5-a834-4516-ad9c-eb92e219d2c3"), new DateTime(2000, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 28" },
                    { new Guid("1acd2dbd-03e7-4bc1-83b9-d868cf4cc740"), new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 46" },
                    { new Guid("1c081b92-ee42-41cb-9f55-55ab303890b7"), new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 8" },
                    { new Guid("1cc12751-9fa0-4b80-9d3b-740a1b053dcd"), new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 9" },
                    { new Guid("22eb8d2c-98a4-4042-9b82-2f00a4e17869"), new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 25" },
                    { new Guid("256e223b-ca11-4e1d-962c-e7ac8c9833ff"), new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 47" },
                    { new Guid("25fcf5e7-952d-449c-9c52-68381d371fe0"), new DateTime(2000, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 48" },
                    { new Guid("37bf21bb-4923-4c5d-a82f-bb834547ae16"), new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 37" },
                    { new Guid("389456d4-d993-4047-b947-620542cf53c5"), new DateTime(2000, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 21" },
                    { new Guid("3d9175bb-e875-4e01-bb86-7a015211519f"), new DateTime(2000, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 50" },
                    { new Guid("4007407c-bbaf-4de6-b405-514f7618b208"), new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 23" },
                    { new Guid("419cc9ce-4912-4a7d-83a6-729f39c67506"), new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 38" },
                    { new Guid("4bec0bca-430a-4ad3-b955-ad6728988f97"), new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 29" },
                    { new Guid("53143645-5c91-4818-8607-3e71c4e96550"), new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 14" },
                    { new Guid("53ca0c73-abbb-4c81-a97b-f6b571f41fc0"), new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 10" },
                    { new Guid("58e06b6a-f6c8-4ea6-a4d3-73948d0b881e"), new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 6" },
                    { new Guid("5c37a10b-b8b5-4a5a-bcb5-ba7a6117d7e2"), new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 44" },
                    { new Guid("5c42f805-0de8-4469-b2e2-0979461a1548"), new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 39" },
                    { new Guid("5d48744e-457a-4175-a0a5-6dca50467e8f"), new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 43" },
                    { new Guid("657dd5c4-5552-4b87-bca3-94c99838aded"), new DateTime(2000, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 40" },
                    { new Guid("71b84be7-a1f6-49c0-b508-eacdfedd5564"), new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 7" },
                    { new Guid("7320ba02-a25e-45ee-a578-d0fc416e9ed7"), new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 32" },
                    { new Guid("75881ccf-e7eb-44c3-90d2-e0650a05a1e4"), new DateTime(2000, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 45" },
                    { new Guid("77303be3-8924-4e5a-87dc-3197bcad905e"), new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 34" },
                    { new Guid("7cd4ca61-1dd8-4447-9068-c106f6362fdd"), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 42" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam Raiden" },
                    { new Guid("84433fc2-1509-4622-827c-587ef8016758"), new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 12" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jana McLeaf" },
                    { new Guid("876bfeba-5d3d-40f7-a5d2-2326e22049ff"), new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 5" },
                    { new Guid("90199e46-811f-49dc-8833-f478bffbd063"), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 33" },
                    { new Guid("94da5813-9391-4f11-bf89-1d431f45b23d"), new DateTime(2000, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 16" },
                    { new Guid("9a925b7d-3c57-475b-bce4-45341f7a43aa"), new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 49" },
                    { new Guid("9b3a28bb-249e-496f-bbc8-0b91884a7618"), new DateTime(2000, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 30" },
                    { new Guid("a5344d0e-380e-4704-a8bd-0040c9db400b"), new DateTime(2000, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 22" },
                    { new Guid("b06c102f-2056-43c4-864d-1c375e0f42b7"), new DateTime(2000, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 24" },
                    { new Guid("ba747abf-6e09-4dff-a26a-b534b8806eb4"), new DateTime(2000, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 17" },
                    { new Guid("bf062b47-518e-4ae9-9702-bb24b1fb1df0"), new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 2" },
                    { new Guid("c6e25fe4-15c6-4e37-ac1f-caee504f0a17"), new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 20" },
                    { new Guid("cdd5fe04-33da-4945-b8f1-738635ee6718"), new DateTime(2000, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 13" },
                    { new Guid("ce3fe6de-5cb8-46df-85ea-98a44986ff16"), new DateTime(2000, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 27" },
                    { new Guid("cf7298be-b1a8-40ee-9683-5cdf4a44ba72"), new DateTime(2000, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 36" },
                    { new Guid("de165303-11ab-4340-b544-bfe17138ab9c"), new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 15" },
                    { new Guid("eeecb951-e754-4a62-92ed-9e67afbddea3"), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 1" },
                    { new Guid("f098b4be-4145-44a3-8e36-c6405c3635dd"), new DateTime(2000, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 41" },
                    { new Guid("f23f2aaa-b3e0-4423-816f-a9be5ca471c7"), new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 11" },
                    { new Guid("f9a33301-35ce-4181-a8e3-c0ae358f15cf"), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 35" },
                    { new Guid("fc3f1d34-5979-45ed-b8fc-f78a9a3e3f75"), new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 4" },
                    { new Guid("fec3f736-3971-41c2-a0cd-428b91c2a8a7"), new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Category 3" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "CategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("0a6292e7-60e3-4720-bd80-8428b30d5165"), "Author- 18", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 18" },
                    { new Guid("12b5d8e3-6c80-41e3-bb97-a92ca842e74b"), "Author- 3", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 3" },
                    { new Guid("1e55a35b-830f-4002-aa81-15f202ac36bc"), "Author- 17", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 17" },
                    { new Guid("2670c404-568f-4d95-a3f0-ca2f2f5294a5"), "Author- 14", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 14" },
                    { new Guid("2721fc24-fac7-49fd-8574-82e9aad69c72"), "Author- 15", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 15" },
                    { new Guid("3b3714d9-fb97-43b0-a7be-702f57ddc8e1"), "Author- 16", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 16" },
                    { new Guid("3b5951eb-4439-4a4f-a2b5-53f5c3d381a4"), "Author- 19", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 19" },
                    { new Guid("41f61e17-4e0f-4d96-b9a6-dfd9a5328400"), "Author- 9", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 9" },
                    { new Guid("43e77e33-c892-4c80-a92e-b2055a284884"), "Author- 4", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 4" },
                    { new Guid("7dd8925b-6d57-489b-a91b-6f437e098bc0"), "Author- 7", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 7" },
                    { new Guid("92a2d71f-8635-4651-bd6a-3b9350d6d3b9"), "Author- 6", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 6" },
                    { new Guid("a2e967e4-4f74-432d-b10a-6efde12ba536"), "Author- 12", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 12" },
                    { new Guid("b3d24c13-df03-4b34-846f-e1b2fb6f9e35"), "Author- 1", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 1" },
                    { new Guid("bc9eca93-9c32-4db0-ae3d-46247d7cb234"), "Author- 5", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 5" },
                    { new Guid("c2382d94-f036-43d0-b5e1-a3379c8abbe7"), "Author- 11", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 11" },
                    { new Guid("cc70a7e1-5333-4fa1-abd6-ea00fbd746bb"), "Author- 8", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 8" },
                    { new Guid("d3d44664-aabe-4062-9424-b72a0dd5a783"), "Author- 20", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 20" },
                    { new Guid("dacb29cd-e2d0-4831-8a34-b45d1c588f23"), "Author- 10", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 10" },
                    { new Guid("dcf8345b-fbbf-4290-9552-d7b62f211e28"), "Author- 13", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 13" },
                    { new Guid("e92f1bc6-5575-40bc-a299-7f53b1305c17"), "Author- 2", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

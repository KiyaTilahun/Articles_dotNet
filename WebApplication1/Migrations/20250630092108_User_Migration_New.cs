using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class User_Migration_New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("0a238c13-f5b6-4ab5-935c-b916df45bf01"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("0ce9bfeb-0769-49fd-8928-fcf9e32f023c"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("10b643d9-e974-45c0-b72d-b5ed65bcfcac"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("20047d92-be8a-435b-9542-7c32d4e3dc38"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("241ac167-ef02-4f23-9028-c56ca09da00c"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("2b14aa3e-ff18-4554-ab84-254cc86313a9"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("668e3325-240b-43e4-967b-bd81a6dff93f"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("77e7e808-6eb6-4a8c-86e1-8066deff8769"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("96f9612a-9a04-4990-a35e-94ccfbbc6ddd"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("a43dd108-f94e-4d0e-9098-45faccf6b4a9"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("b14ea5f8-e9a4-46c3-a9b5-6da1ec98494f"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("b8fda8c7-612d-4297-b4db-c2d0ce2361d8"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("b9897ce9-361e-4faf-8830-49afc789091a"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("cd98fcb9-ff19-4fe5-bd5e-b34512c95b21"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("d0949bda-be0f-49fe-b123-7c4c6b63e55e"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("d0e9793d-121e-461a-84cc-80f8276a2a54"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("d81835f5-1a70-47f7-8096-dcee045cea95"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("da0635e8-5fc9-4af0-bcc9-3d16e19212d9"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("e3350d8c-0642-4774-8f1e-dc704440650e"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("fdb03cdd-2963-478d-bf40-47d16e1dd008"));

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "CategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("040d2e34-e94e-4ad8-8f1d-17cf1173ef69"), "Author- 16", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 16" },
                    { new Guid("1a4c4405-d512-41d6-81ac-3ce2c5700b4d"), "Author- 17", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 17" },
                    { new Guid("1b5084a0-2f12-470e-aefd-e3c3a441d9ad"), "Author- 2", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 2" },
                    { new Guid("2110d82b-57a8-4236-abfe-bb35e3953bc5"), "Author- 19", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 19" },
                    { new Guid("3d1dad4d-daf2-4e1d-af1a-9cb6a5f7c417"), "Author- 18", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 18" },
                    { new Guid("589d90ed-9520-4271-909f-c0adb4fbabd9"), "Author- 14", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 14" },
                    { new Guid("6326ebd9-01b0-46cf-ba33-bf0cd089a136"), "Author- 9", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 9" },
                    { new Guid("757c74e8-5c11-4e65-9a2b-7c1587fbb6a2"), "Author- 5", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 5" },
                    { new Guid("7ac767af-7af2-4112-9eb7-703c2f516e8d"), "Author- 8", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 8" },
                    { new Guid("834f0cd3-b680-4843-845c-4a9ba1f133ae"), "Author- 10", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 10" },
                    { new Guid("8461d7d0-a5da-46c9-adf4-d84f83e2b997"), "Author- 12", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 12" },
                    { new Guid("96ef2d20-ef19-441c-bb74-2bb1481f4e43"), "Author- 4", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 4" },
                    { new Guid("98d13801-3551-4ff3-a60a-024f95a5268e"), "Author- 1", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 1" },
                    { new Guid("9e838b6e-7058-4cba-8811-ab289a666e96"), "Author- 20", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 20" },
                    { new Guid("b249d8e9-1e25-4ac5-b2d4-09c845eea505"), "Author- 11", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 11" },
                    { new Guid("c0c8d197-9454-4d88-a1d9-5d3d4404fa40"), "Author- 13", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 13" },
                    { new Guid("d207e41b-0e35-4d23-9848-0f937c72c816"), "Author- 3", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 3" },
                    { new Guid("da1e3646-d9da-4db6-8228-b0edf795fbfe"), "Author- 7", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 7" },
                    { new Guid("dabe26d0-ac0b-4fcc-8a6e-52b3d01343c4"), "Author- 6", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 6" },
                    { new Guid("eb28b87f-6739-4234-9310-5822beb55daf"), "Author- 15", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("040d2e34-e94e-4ad8-8f1d-17cf1173ef69"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("1a4c4405-d512-41d6-81ac-3ce2c5700b4d"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("1b5084a0-2f12-470e-aefd-e3c3a441d9ad"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("2110d82b-57a8-4236-abfe-bb35e3953bc5"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("3d1dad4d-daf2-4e1d-af1a-9cb6a5f7c417"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("589d90ed-9520-4271-909f-c0adb4fbabd9"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("6326ebd9-01b0-46cf-ba33-bf0cd089a136"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("757c74e8-5c11-4e65-9a2b-7c1587fbb6a2"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("7ac767af-7af2-4112-9eb7-703c2f516e8d"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("834f0cd3-b680-4843-845c-4a9ba1f133ae"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("8461d7d0-a5da-46c9-adf4-d84f83e2b997"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("96ef2d20-ef19-441c-bb74-2bb1481f4e43"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("98d13801-3551-4ff3-a60a-024f95a5268e"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("9e838b6e-7058-4cba-8811-ab289a666e96"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("b249d8e9-1e25-4ac5-b2d4-09c845eea505"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("c0c8d197-9454-4d88-a1d9-5d3d4404fa40"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("d207e41b-0e35-4d23-9848-0f937c72c816"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("da1e3646-d9da-4db6-8228-b0edf795fbfe"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("dabe26d0-ac0b-4fcc-8a6e-52b3d01343c4"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("eb28b87f-6739-4234-9310-5822beb55daf"));

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "CategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("0a238c13-f5b6-4ab5-935c-b916df45bf01"), "Author- 5", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 5" },
                    { new Guid("0ce9bfeb-0769-49fd-8928-fcf9e32f023c"), "Author- 20", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 20" },
                    { new Guid("10b643d9-e974-45c0-b72d-b5ed65bcfcac"), "Author- 18", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 18" },
                    { new Guid("20047d92-be8a-435b-9542-7c32d4e3dc38"), "Author- 13", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 13" },
                    { new Guid("241ac167-ef02-4f23-9028-c56ca09da00c"), "Author- 10", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 10" },
                    { new Guid("2b14aa3e-ff18-4554-ab84-254cc86313a9"), "Author- 2", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 2" },
                    { new Guid("668e3325-240b-43e4-967b-bd81a6dff93f"), "Author- 7", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 7" },
                    { new Guid("77e7e808-6eb6-4a8c-86e1-8066deff8769"), "Author- 14", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 14" },
                    { new Guid("96f9612a-9a04-4990-a35e-94ccfbbc6ddd"), "Author- 17", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 17" },
                    { new Guid("a43dd108-f94e-4d0e-9098-45faccf6b4a9"), "Author- 11", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 11" },
                    { new Guid("b14ea5f8-e9a4-46c3-a9b5-6da1ec98494f"), "Author- 12", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 12" },
                    { new Guid("b8fda8c7-612d-4297-b4db-c2d0ce2361d8"), "Author- 4", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 4" },
                    { new Guid("b9897ce9-361e-4faf-8830-49afc789091a"), "Author- 15", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 15" },
                    { new Guid("cd98fcb9-ff19-4fe5-bd5e-b34512c95b21"), "Author- 8", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 8" },
                    { new Guid("d0949bda-be0f-49fe-b123-7c4c6b63e55e"), "Author- 3", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 3" },
                    { new Guid("d0e9793d-121e-461a-84cc-80f8276a2a54"), "Author- 19", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 19" },
                    { new Guid("d81835f5-1a70-47f7-8096-dcee045cea95"), "Author- 1", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 1" },
                    { new Guid("da0635e8-5fc9-4af0-bcc9-3d16e19212d9"), "Author- 9", new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "title - 9" },
                    { new Guid("e3350d8c-0642-4774-8f1e-dc704440650e"), "Author- 6", new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "title - 6" },
                    { new Guid("fdb03cdd-2963-478d-bf40-47d16e1dd008"), "Author- 16", new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "title - 16" }
                });
        }
    }
}

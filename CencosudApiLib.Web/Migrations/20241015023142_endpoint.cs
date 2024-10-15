using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class endpoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "378c033a-f195-4ef4-a8d7-ed1a8ad52b1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3ca3e5dc-4bb7-44c7-96fc-53d7c0c50bd0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3d3930b6-7e5c-4377-b4c9-cf5efc01fa30" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "52981758-e427-49a0-b0b4-d126dfe5cf83" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "52c59b9b-0fbd-4e46-bd36-e4a44c3e21ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "88c22a4a-ac8b-4217-8934-9ac3a2190af5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "93a972a2-2b41-4caf-91b7-fbf156da6cc7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a13587aa-2bc9-469d-81d7-ec84f07f0766" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a971988d-a970-4153-8e1a-809a36fdcf0e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c199f4cc-0b00-4d65-89f1-b9fd01fa726b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ecf5a9fd-a7ba-4a09-aef2-4c99986a1336" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fa7b2c75-c45d-453b-93a4-254d2e633d5d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "378c033a-f195-4ef4-a8d7-ed1a8ad52b1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ca3e5dc-4bb7-44c7-96fc-53d7c0c50bd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d3930b6-7e5c-4377-b4c9-cf5efc01fa30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52981758-e427-49a0-b0b4-d126dfe5cf83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52c59b9b-0fbd-4e46-bd36-e4a44c3e21ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88c22a4a-ac8b-4217-8934-9ac3a2190af5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a972a2-2b41-4caf-91b7-fbf156da6cc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a13587aa-2bc9-469d-81d7-ec84f07f0766");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a971988d-a970-4153-8e1a-809a36fdcf0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c199f4cc-0b00-4d65-89f1-b9fd01fa726b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecf5a9fd-a7ba-4a09-aef2-4c99986a1336");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa7b2c75-c45d-453b-93a4-254d2e633d5d");

            migrationBuilder.CreateTable(
                name: "Endpoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApiId = table.Column<int>(type: "integer", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    Method = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endpoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endpoints_Apis_ApiId",
                        column: x => x.ApiId,
                        principalTable: "Apis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "20284a81-cd26-45a5-b58d-8c73718362bb", 0, "7efd5ef7-b6e6-4656-83fd-396758828f2d", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEHoA75vsEVH0RwiWlznJIk0W5PB5SANjR1TeMS1gxLWWA9sQOhWZ1XXfshe8iUasAw==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 40, 991, DateTimeKind.Local).AddTicks(7876), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "298c2b75-7224-4556-929b-e41bbc2cbf3f", 0, "4664c34a-06cc-4b67-8ee1-b76e454de8ae", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEBXFgdZRo77hof+MsgNEl316RJqIN7dV6+v2J3jSNGaBc9YGGj7gMU5TMQnDuiqGKg==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 41, 124, DateTimeKind.Local).AddTicks(5963), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "33d59786-1088-4981-9177-84b2f8d1a97a", 0, "82d42f00-7911-4b1e-a09f-f924037c221d", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEFcXbR+EuGsbkHZAbPTNMhTWZg9/wxv9E1EALZjE8N5se4fdu13ACCj5ZLcWA0GzAA==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 41, 197, DateTimeKind.Local).AddTicks(4279), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "78e72cb3-7848-4f82-807e-fa4d338435cb", 0, "dded466c-ee7a-4b1c-bf5e-b50e3d6e4251", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEEdj50WyPQnX7iXCrp1wsKbBtqx7nvTrEt6nBYyVgsMn3EoyT/iN1PHF5bS3mh7uBg==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 41, 276, DateTimeKind.Local).AddTicks(2275), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "7da9b014-058e-4dcf-a2c4-0d8bd8dab9a9", 0, "978598d5-ef1d-4f34-ad64-04ef24ab670f", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEDM7mtZT44XSqy1N4nK2mWE9bHJHuMRGxSpbEDdXGeTFhDZol8AGaTFZELY4/Zk7EQ==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 41, 59, DateTimeKind.Local).AddTicks(3721), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "93a118fa-2c18-4135-abf9-69f012f54275", 0, "74b2f9e1-65d9-44df-a3fa-232ff3e25c7a", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEP3izhWD6bTy9opXakZbS1IzpkfQALe5RiE3x4BVEl25WVPai3alG6kNkSMTv17C7g==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 40, 919, DateTimeKind.Local).AddTicks(9652), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "9e3bf8a8-ee81-45b5-8e93-4bac676a2745", 0, "023681ab-c85a-4387-938d-a97a492854c0", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEBpV7wjXzMRmW+c5csItWXB4O4ZTfGHPJpuTHFBqXXHvNtx8ttn7/jfDLrb1AqO2Ng==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 41, 362, DateTimeKind.Local).AddTicks(719), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "b3f1b1d1-afdd-4ad5-989a-318acdcb49f1", 0, "45598e11-521b-483a-9435-615ba228b941", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAENS9s3MoQ4CBrcMC4splj29zU2NISixLh5pYXnuqrGRJLz4G/dzusIucAz8OsVNQbA==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 40, 841, DateTimeKind.Local).AddTicks(2194), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "b852a377-2e63-4687-b7e8-eba9c63259f6", 0, "f629465a-a6d3-4693-9e29-b035a182b271", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAENc0GGoaC9NnK66l5SsmBW8OjVPTvwFZ2EWi3me1Av7XUkBmhbgI2fo0298ImrgMVw==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 41, 440, DateTimeKind.Local).AddTicks(6917), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "c78d5d0d-d6cb-42cf-918d-16cb5fa32514", 0, "e2d8d149-7102-477b-b61c-1c61d1701d3f", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEPovCJOrEYqlk42XqDC5LsZ6ciWIK2W74rHWKza7eo7MpgSdb/glkNzeBgcbeJuW2w==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 40, 758, DateTimeKind.Local).AddTicks(7426), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "ceb5ec7e-c7d2-4172-8392-4374d254d6a9", 0, "ca410d17-9ed8-4528-8b05-090239a849c1", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEEXu8CdTecD4mWjgIf2lt3Yyc4953oKhWiw6qlsBwCkuKFAdqITSjivE01m4uPtJBQ==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 40, 693, DateTimeKind.Local).AddTicks(1294), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "e3bad1d4-cfdc-480d-86b2-8a97ec8be835", 0, "586524af-98eb-4fa7-aced-7ac99d32f4a0", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEJGAToJS4nlWHpUg7s1RxKe/lzFHv3MAkjQMwNxXeV5ThZlNupc68Y5yuq4TSLJVPA==", null, false, "", new DateTime(2024, 10, 14, 23, 31, 40, 622, DateTimeKind.Local).AddTicks(6620), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "20284a81-cd26-45a5-b58d-8c73718362bb" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "298c2b75-7224-4556-929b-e41bbc2cbf3f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "33d59786-1088-4981-9177-84b2f8d1a97a" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "78e72cb3-7848-4f82-807e-fa4d338435cb" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7da9b014-058e-4dcf-a2c4-0d8bd8dab9a9" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "93a118fa-2c18-4135-abf9-69f012f54275" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9e3bf8a8-ee81-45b5-8e93-4bac676a2745" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b3f1b1d1-afdd-4ad5-989a-318acdcb49f1" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b852a377-2e63-4687-b7e8-eba9c63259f6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c78d5d0d-d6cb-42cf-918d-16cb5fa32514" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ceb5ec7e-c7d2-4172-8392-4374d254d6a9" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e3bad1d4-cfdc-480d-86b2-8a97ec8be835" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endpoints_ApiId",
                table: "Endpoints",
                column: "ApiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endpoints");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "20284a81-cd26-45a5-b58d-8c73718362bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "298c2b75-7224-4556-929b-e41bbc2cbf3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "33d59786-1088-4981-9177-84b2f8d1a97a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "78e72cb3-7848-4f82-807e-fa4d338435cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7da9b014-058e-4dcf-a2c4-0d8bd8dab9a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "93a118fa-2c18-4135-abf9-69f012f54275" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9e3bf8a8-ee81-45b5-8e93-4bac676a2745" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b3f1b1d1-afdd-4ad5-989a-318acdcb49f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b852a377-2e63-4687-b7e8-eba9c63259f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c78d5d0d-d6cb-42cf-918d-16cb5fa32514" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ceb5ec7e-c7d2-4172-8392-4374d254d6a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e3bad1d4-cfdc-480d-86b2-8a97ec8be835" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20284a81-cd26-45a5-b58d-8c73718362bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "298c2b75-7224-4556-929b-e41bbc2cbf3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d59786-1088-4981-9177-84b2f8d1a97a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78e72cb3-7848-4f82-807e-fa4d338435cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7da9b014-058e-4dcf-a2c4-0d8bd8dab9a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a118fa-2c18-4135-abf9-69f012f54275");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e3bf8a8-ee81-45b5-8e93-4bac676a2745");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3f1b1d1-afdd-4ad5-989a-318acdcb49f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b852a377-2e63-4687-b7e8-eba9c63259f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c78d5d0d-d6cb-42cf-918d-16cb5fa32514");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ceb5ec7e-c7d2-4172-8392-4374d254d6a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3bad1d4-cfdc-480d-86b2-8a97ec8be835");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "378c033a-f195-4ef4-a8d7-ed1a8ad52b1d", 0, "2f4b9394-ceb7-4875-9b26-643d9d90d34f", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEOHrgHLDJRT3l77Z9dVS90zhsyQDq/yMhNjNsSdKQZIGMhs55eBxlmGLh8+Vr0gWbw==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 45, 63, DateTimeKind.Local).AddTicks(1074), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "3ca3e5dc-4bb7-44c7-96fc-53d7c0c50bd0", 0, "2f53ca72-0cf5-43c2-8dcd-410b5c4e67ee", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEH1w3pP0a5s3MOYTStaBKXOSLo7gEj1TuoCjnzi8cHLOPb8UJyJqcSygVhcPRKF3Ww==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 45, 607, DateTimeKind.Local).AddTicks(5029), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "3d3930b6-7e5c-4377-b4c9-cf5efc01fa30", 0, "82f308a5-2bcf-4e37-99c8-8420a1220835", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEDPZOCnq3TcDsHKgaG78WnzF71yBTcj1EE5tIP6Chx3iqOxLjXwwyScj97rxQ8gohQ==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 46, 561, DateTimeKind.Local).AddTicks(3305), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "52981758-e427-49a0-b0b4-d126dfe5cf83", 0, "508b6ebe-d671-4cad-9983-e169874c2851", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAENcw4ULwdRc4XL5/W5ih9fSw2axk6mEm7DZ/KY7+juTOmg3mrXMFVY5t2zB0ur8ffQ==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 45, 887, DateTimeKind.Local).AddTicks(6403), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "52c59b9b-0fbd-4e46-bd36-e4a44c3e21ef", 0, "1847fcda-c616-4964-b702-8491bb5531d4", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEKDsg9l95BZLUfz1+grZxtlsmAYrGVi4+CkgLwPLQfLv/pkB+6T0UzfoXXorC6yk5w==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 46, 312, DateTimeKind.Local).AddTicks(8402), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "88c22a4a-ac8b-4217-8934-9ac3a2190af5", 0, "561135ce-fca7-4f17-9990-73ce6e658d01", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEHMCNZjCKunXDzJOXzUioO6owPVy865icadt8KMtrVBLRRUMUrxBdochkxkuHc3adw==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 46, 172, DateTimeKind.Local).AddTicks(1432), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "93a972a2-2b41-4caf-91b7-fbf156da6cc7", 0, "b2adb819-3785-4e8c-aedf-bdc07da0711d", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEMMqi0a7PnUQE3JJOc8upokKE9l+HXv0t1SAgl1s52Q/zo0G6T3PQI0yoGSEwxAFBg==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 45, 740, DateTimeKind.Local).AddTicks(8017), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "a13587aa-2bc9-469d-81d7-ec84f07f0766", 0, "223de7d5-4071-4a5e-9af3-797053aa7fbc", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEFtoXck9+p3CDPN4IPvHlhMSaJS0OWd7lWwofRpJxnCiJiJTkf1s37aULRnNgYl92A==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 46, 18, DateTimeKind.Local).AddTicks(4855), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "a971988d-a970-4153-8e1a-809a36fdcf0e", 0, "61f4554b-72ec-4357-a45b-650d1ed3306b", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEOt1TcyZGPW5gMr6HuLJzLLLcmPNoCtpeg/BviCa+7NzkcxW9LlpzapIigvSUJXTcA==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 45, 194, DateTimeKind.Local).AddTicks(1481), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "c199f4cc-0b00-4d65-89f1-b9fd01fa726b", 0, "2ccbac66-2430-4aa1-9c81-733ac4690263", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEB4DpFnyMP5SSDzd41Ml0x31QQPTBB+aUGHqMTSUNV/TUeEIlIDLfgcI9gjnkZm9+g==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 45, 462, DateTimeKind.Local).AddTicks(1557), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "ecf5a9fd-a7ba-4a09-aef2-4c99986a1336", 0, "3a5076cb-9ff7-45dd-a216-bce0446c7db7", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEHnUKOWgue/sLknAdOA5EKkF9vaWMO1gOSsR6gZOJpyhVURskMo0qaFq2pkdWhuxgA==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 45, 320, DateTimeKind.Local).AddTicks(2284), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "fa7b2c75-c45d-453b-93a4-254d2e633d5d", 0, "3e88e08a-8f0d-4363-bddf-7ecc6ba267ec", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEBWl3XPNqPdGPfdFmh6YpHiwZYkTd/+bPPyuYOEZd+/fbyVsFl/aHEqjWm4SaCoYdw==", null, false, "", new DateTime(2024, 10, 8, 19, 44, 46, 446, DateTimeKind.Local).AddTicks(47), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "378c033a-f195-4ef4-a8d7-ed1a8ad52b1d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3ca3e5dc-4bb7-44c7-96fc-53d7c0c50bd0" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3d3930b6-7e5c-4377-b4c9-cf5efc01fa30" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "52981758-e427-49a0-b0b4-d126dfe5cf83" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "52c59b9b-0fbd-4e46-bd36-e4a44c3e21ef" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "88c22a4a-ac8b-4217-8934-9ac3a2190af5" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "93a972a2-2b41-4caf-91b7-fbf156da6cc7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a13587aa-2bc9-469d-81d7-ec84f07f0766" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a971988d-a970-4153-8e1a-809a36fdcf0e" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c199f4cc-0b00-4d65-89f1-b9fd01fa726b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ecf5a9fd-a7ba-4a09-aef2-4c99986a1336" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fa7b2c75-c45d-453b-93a4-254d2e633d5d" }
                });
        }
    }
}

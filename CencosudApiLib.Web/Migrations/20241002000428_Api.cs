using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class Api : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1059d8b0-bc66-43f1-8ca6-022adeafd922" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "17a3d97b-283f-4f74-9a50-8030d49cf490" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3586fe29-6f87-4011-b07d-7d70d5d36af0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "57af8f72-6e80-4dd4-8bb2-3c06f49e3c69" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5d1ef2d7-39d1-4770-81a2-6e72ea62d474" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6c060b43-3567-44a1-8f0e-197315136ae2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9a6c3367-8efb-4813-aa4b-7dd3b3585dd9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9af8f119-d3b3-438b-90fe-99e3b58cc79a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a09720c5-3988-430e-b402-206d5562337a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "bd9d7fbd-074f-4f0a-bc60-cb43dbd767c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "cd6b63eb-f1f1-4c34-a421-1aa29939cac9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "eb82d3ff-644d-4233-a2a1-c091fc61c3f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1059d8b0-bc66-43f1-8ca6-022adeafd922");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17a3d97b-283f-4f74-9a50-8030d49cf490");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3586fe29-6f87-4011-b07d-7d70d5d36af0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57af8f72-6e80-4dd4-8bb2-3c06f49e3c69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d1ef2d7-39d1-4770-81a2-6e72ea62d474");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c060b43-3567-44a1-8f0e-197315136ae2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a6c3367-8efb-4813-aa4b-7dd3b3585dd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9af8f119-d3b3-438b-90fe-99e3b58cc79a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a09720c5-3988-430e-b402-206d5562337a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd9d7fbd-074f-4f0a-bc60-cb43dbd767c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd6b63eb-f1f1-4c34-a421-1aa29939cac9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb82d3ff-644d-4233-a2a1-c091fc61c3f4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "0a5d5489-d2cb-4d45-b2f3-be91ab7e5fdf", 0, "fd81a7f3-f22a-433a-9a88-646a0afc1562", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEI8NCBJnMi0uuNxu5CRnzVWItfe1OqKEli8++Yr8GisnyMUOmg7E9GgmrCHIRQszjA==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 28, 137, DateTimeKind.Local).AddTicks(2202), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "0bead3cf-17a4-4385-a93b-0af644c25963", 0, "eba7ec03-c58a-4400-95cd-e53b6044912b", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEA0HzyZQJNd3lMkG77tcOpbF+HjpckK14cX2uDj8ZcICjKJ36abF80iwiXx0ZQ3aZQ==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 27, 467, DateTimeKind.Local).AddTicks(1883), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "1139b93e-2f4c-40b9-a5a0-bf3728e4af52", 0, "9f62b444-2ad3-42af-8d09-a459fce5f5b6", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEE566yG1BEMTdg3fynqIoUSxeHq0hlCqTFGsE33t/SdUFtTFrRGjYKEZUM0Nh9rL0A==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 27, 813, DateTimeKind.Local).AddTicks(1892), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "1bb80571-45e9-474b-b50a-2749ef3ff9bd", 0, "1df8ba88-6b2a-497e-8517-fd2373ae13e1", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEHT43MJZeAoXVOZHtmZoTFin0I45bw5lo43R1yTNY8bnDH6OO8kWmUneliXsajQ0bQ==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 27, 674, DateTimeKind.Local).AddTicks(4758), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "37b52700-9a45-4a7f-9cc3-4797db60d52b", 0, "306a09c8-aa98-47f8-9a1c-f4add582f3ac", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAECNzvoKXmxpKA+niG1ch7pxyoCq+YXyuc5cYvMqxDUVN/ewRJttpVaUEiMoOIO9vEA==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 27, 743, DateTimeKind.Local).AddTicks(7052), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "669df4b7-67e3-4d08-b7ff-464a8edd445b", 0, "0ef675fc-6df5-4d4f-be6c-3f211aa69a18", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEDy/Kzf6EBiYEVOTZnsjjRUAZgZ5cFKW6My7DnjsVEcSYT4CKGbYdINHFaJDdD+Pmg==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 28, 16, DateTimeKind.Local).AddTicks(3855), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "9194593b-b566-4158-ac88-56c6d065cef6", 0, "69cd7776-1998-464e-9284-1c7b713de696", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEH77KW+6mQYN2PojzLGOwW//B1WFpq4VC0V8dD3asU3neIyj/U/J41MDqVUL8zVpEQ==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 27, 532, DateTimeKind.Local).AddTicks(3886), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "94fd9a78-e8c5-4c7b-a540-b2b72681c0ff", 0, "c61ee08f-95b1-430e-845d-51c3cc8e5e46", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEHtkW4/QeTB3ZAx0HXaPz5AAMShPXsFRQwqkv6lrVbJnElwqVR7yp+4BWrNXETof9g==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 27, 956, DateTimeKind.Local).AddTicks(6745), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "b7b4adaa-3c1f-4a48-819b-02dd7dd6681e", 0, "9671da9f-4837-4d4d-ba12-07fa70d033e8", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEN6XQnVALYvEwNnVIYKXV5RxRE7PGNiwxqpR1FitHNi3buGGZlXrq1znWm3YXemZOA==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 28, 77, DateTimeKind.Local).AddTicks(2859), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "b9009946-4d95-4794-870b-af3d7c080149", 0, "8ac70daf-6055-419d-87f7-4026d1384249", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEDFlVJWXGPpq+0hp5X3fUyfpNWOOOGvfgqXzrwreYm/DQmtcQ5EIpRTJGg7EUvnz+g==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 27, 890, DateTimeKind.Local).AddTicks(4860), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "bbb349db-a8f4-4e56-8e48-38ab8df74e22", 0, "202e8b5a-0c31-4ed2-8cb6-acddfc53d5cd", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEKs7mmR/0XTpMmIgzw569t6knQ30goGXeipd3sJwywQC/k+NET9WB+1HbdVIa/LR7w==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 27, 609, DateTimeKind.Local).AddTicks(2571), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "cfe4dafc-6b8e-4a62-a3ab-0dda78f65630", 0, "17206ee7-7b16-4fc1-90a0-155a8149e049", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEPhmjXbF4tDRMFkLJARn3LeDIK2dAwjSibDNkG622djyrW9wERBj6SCj65DI0kibpg==", null, false, "", new DateTime(2024, 10, 1, 21, 4, 28, 234, DateTimeKind.Local).AddTicks(3142), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0a5d5489-d2cb-4d45-b2f3-be91ab7e5fdf" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0bead3cf-17a4-4385-a93b-0af644c25963" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1139b93e-2f4c-40b9-a5a0-bf3728e4af52" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1bb80571-45e9-474b-b50a-2749ef3ff9bd" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "37b52700-9a45-4a7f-9cc3-4797db60d52b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "669df4b7-67e3-4d08-b7ff-464a8edd445b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9194593b-b566-4158-ac88-56c6d065cef6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "94fd9a78-e8c5-4c7b-a540-b2b72681c0ff" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b7b4adaa-3c1f-4a48-819b-02dd7dd6681e" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b9009946-4d95-4794-870b-af3d7c080149" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "bbb349db-a8f4-4e56-8e48-38ab8df74e22" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "cfe4dafc-6b8e-4a62-a3ab-0dda78f65630" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0a5d5489-d2cb-4d45-b2f3-be91ab7e5fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0bead3cf-17a4-4385-a93b-0af644c25963" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1139b93e-2f4c-40b9-a5a0-bf3728e4af52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1bb80571-45e9-474b-b50a-2749ef3ff9bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "37b52700-9a45-4a7f-9cc3-4797db60d52b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "669df4b7-67e3-4d08-b7ff-464a8edd445b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9194593b-b566-4158-ac88-56c6d065cef6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "94fd9a78-e8c5-4c7b-a540-b2b72681c0ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b7b4adaa-3c1f-4a48-819b-02dd7dd6681e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b9009946-4d95-4794-870b-af3d7c080149" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "bbb349db-a8f4-4e56-8e48-38ab8df74e22" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "cfe4dafc-6b8e-4a62-a3ab-0dda78f65630" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a5d5489-d2cb-4d45-b2f3-be91ab7e5fdf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bead3cf-17a4-4385-a93b-0af644c25963");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1139b93e-2f4c-40b9-a5a0-bf3728e4af52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bb80571-45e9-474b-b50a-2749ef3ff9bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37b52700-9a45-4a7f-9cc3-4797db60d52b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "669df4b7-67e3-4d08-b7ff-464a8edd445b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9194593b-b566-4158-ac88-56c6d065cef6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94fd9a78-e8c5-4c7b-a540-b2b72681c0ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7b4adaa-3c1f-4a48-819b-02dd7dd6681e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9009946-4d95-4794-870b-af3d7c080149");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbb349db-a8f4-4e56-8e48-38ab8df74e22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfe4dafc-6b8e-4a62-a3ab-0dda78f65630");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "1059d8b0-bc66-43f1-8ca6-022adeafd922", 0, "07e8e8b8-1383-4706-937c-5e68022ba8ee", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEKpXdQ3M/fQQnU8Lc9NIRyr49Ne6bZN4p6sWPReMshB3zI/fPQnh39znoDjrUppN1A==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 48, 737, DateTimeKind.Local).AddTicks(4769), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "17a3d97b-283f-4f74-9a50-8030d49cf490", 0, "1579d497-7a82-4be0-adc1-ce509d09d820", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAECVzO3Z9JfWrjxcCZUpaGDBo6wfIxtrnJT9kwHvp1Awz/2jU/Xag0l5uP1gI21wfDg==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 49, 131, DateTimeKind.Local).AddTicks(6295), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "3586fe29-6f87-4011-b07d-7d70d5d36af0", 0, "2624ed34-ab43-41b5-abe4-8f465690bb86", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEPAz70Rps7tLWzyW889phq6hvobIhMuZ4A1Vj4zvVio913jETL/yoFHmKsaxrAZY1Q==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 48, 933, DateTimeKind.Local).AddTicks(9308), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "57af8f72-6e80-4dd4-8bb2-3c06f49e3c69", 0, "7b66c868-da0c-4b11-8a33-6e9047e1ae17", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEEHe4+/R9c/+ZApAu//1MD/UR6B1/bBArauKHtO5Q2fRPzrFwXoorDaHO3qO9DsQww==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 48, 858, DateTimeKind.Local).AddTicks(9497), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "5d1ef2d7-39d1-4770-81a2-6e72ea62d474", 0, "998f72ba-127a-46de-83a2-b58e2af77445", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEDcJF2mrEyjs3m4Bu9mS1XB9AJDPT9+Lr2Mo2Ys5OIaY9/vmFVc6AwT2JdSdhZgBWQ==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 49, 259, DateTimeKind.Local).AddTicks(1639), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "6c060b43-3567-44a1-8f0e-197315136ae2", 0, "c94de589-2b33-49a0-90de-e68067577286", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEMsQbJTcuTSGrOGb/i+JUkOReBLW8kOvzqGlvhE9aRuOqp7LQaRSGP+qbI1FPtyFZg==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 49, 69, DateTimeKind.Local).AddTicks(3598), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "9a6c3367-8efb-4813-aa4b-7dd3b3585dd9", 0, "2c800869-3072-4de8-ae1e-bb52a1184d29", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEFR6227vahHjwAEWRjhiuYfh7988oI2vnUfJ3SP+TodEGnOls1/4UnSOLxGAvwwtVg==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 49, 194, DateTimeKind.Local).AddTicks(752), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "9af8f119-d3b3-438b-90fe-99e3b58cc79a", 0, "bbb53461-bcac-4eae-85ed-f4f795101cab", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEPJUBLTHWTo9le+PskeChvzMrp8kbGx4q+0VhfSHMPte04QSsijMDjdCvA2/4LN8Lw==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 49, 8, DateTimeKind.Local).AddTicks(8745), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "a09720c5-3988-430e-b402-206d5562337a", 0, "2e7456d9-e2d4-4443-9e8c-4ada23ffcdf7", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEO/9MjN3Gj3n1fArMidPMjvTA7XTmWb83JNbpLWxMIofGvGJ9WgoKxeS17yzAjptdg==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 49, 319, DateTimeKind.Local).AddTicks(9093), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "bd9d7fbd-074f-4f0a-bc60-cb43dbd767c7", 0, "dc07b7ee-8d77-4d3a-9846-7a3191ad51c6", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEItjiZEGsufG4L7xXHcjAT9K6cVf6WUlcHAaWh2izudxupSqmanUgYnH4pDjQlIpBw==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 48, 798, DateTimeKind.Local).AddTicks(6925), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "cd6b63eb-f1f1-4c34-a421-1aa29939cac9", 0, "ebce22ae-7943-41f8-bfdb-0e11b7b13810", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEGqS7Y+2yh3DmWya3r1bMuH3dkRqHI1wMxkPLsYqBbfI86FSQtctbgBQZHKmErlnMg==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 48, 676, DateTimeKind.Local).AddTicks(6777), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "eb82d3ff-644d-4233-a2a1-c091fc61c3f4", 0, "8b56f0c3-a8be-46d9-b3c3-a9b1df04c842", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEMN6prgnR/JmfcdZOGh8pQoJYNBaJdzRuyGh+re+gmmzRYbbrtebzYid48sSllOZ/g==", null, false, "", new DateTime(2024, 9, 9, 19, 9, 49, 381, DateTimeKind.Local).AddTicks(716), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1059d8b0-bc66-43f1-8ca6-022adeafd922" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "17a3d97b-283f-4f74-9a50-8030d49cf490" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3586fe29-6f87-4011-b07d-7d70d5d36af0" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "57af8f72-6e80-4dd4-8bb2-3c06f49e3c69" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5d1ef2d7-39d1-4770-81a2-6e72ea62d474" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6c060b43-3567-44a1-8f0e-197315136ae2" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9a6c3367-8efb-4813-aa4b-7dd3b3585dd9" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9af8f119-d3b3-438b-90fe-99e3b58cc79a" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a09720c5-3988-430e-b402-206d5562337a" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "bd9d7fbd-074f-4f0a-bc60-cb43dbd767c7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "cd6b63eb-f1f1-4c34-a421-1aa29939cac9" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "eb82d3ff-644d-4233-a2a1-c091fc61c3f4" }
                });
        }
    }
}

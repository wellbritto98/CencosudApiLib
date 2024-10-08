using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class removeresponsaveltecnico2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apis_AspNetUsers_UserId",
                table: "Apis");

            migrationBuilder.DropIndex(
                name: "IX_Apis_UserId",
                table: "Apis");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0483e647-701b-4930-a3a6-8cca99d8ed3c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1a7c95b4-8851-4b28-987e-0c61feb77d1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2cd94bcf-4883-4a30-b077-2f7bc91848ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "33c4e333-c141-48eb-81d8-a98cd61880a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "373c7fea-0520-4308-8d37-f1770f117576" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "43207aee-2889-4ca4-a919-dbb663f9b209" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "542e2ebd-0d5a-4211-bf9c-550057de0fad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5ae5719b-cab5-427e-9fa3-469e1dc41035" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "673ce8be-783a-4b8c-88ce-31cd11bcc76d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c2328c59-a5db-4756-8800-512bf17ab76a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "da20ee8d-2d64-4b94-9eb4-f0aadefd8d9e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e8e408b5-86b5-424f-b8df-ca946ba83970" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0483e647-701b-4930-a3a6-8cca99d8ed3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a7c95b4-8851-4b28-987e-0c61feb77d1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd94bcf-4883-4a30-b077-2f7bc91848ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33c4e333-c141-48eb-81d8-a98cd61880a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "373c7fea-0520-4308-8d37-f1770f117576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43207aee-2889-4ca4-a919-dbb663f9b209");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "542e2ebd-0d5a-4211-bf9c-550057de0fad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ae5719b-cab5-427e-9fa3-469e1dc41035");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673ce8be-783a-4b8c-88ce-31cd11bcc76d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2328c59-a5db-4756-8800-512bf17ab76a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da20ee8d-2d64-4b94-9eb4-f0aadefd8d9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8e408b5-86b5-424f-b8df-ca946ba83970");

            migrationBuilder.DropColumn(
                name: "ResponsavelTecnico",
                table: "Apis");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Apis");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "096e855e-f37d-44d5-9ac1-cd9e71bda802", 0, "4525654d-8bb5-42cc-ab04-de89a31bbfcb", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEMrmQWVm1yRIPnt4CkeOwkfLoQ8jq7dJI7nVwsmNBK446RFRKeqM4CArZFMzu7XHaw==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 977, DateTimeKind.Local).AddTicks(432), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "29e6c26c-1061-4a8e-bfe0-e159cf780ace", 0, "8d5acbc1-98ea-4d10-a972-a37ec2cb3220", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEA5JdVZnLKO39wKINDajJAiwsqWzKBN4v9URYGF7MHqbPInk8fJjMgVzSqZO6+RnoA==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 801, DateTimeKind.Local).AddTicks(8672), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "356c7c60-ce12-4615-98aa-a7f2208cbca3", 0, "dc0610e0-e796-43e7-87a7-50c1ed9262f1", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEBdCrHgRmQERZqviDY7uOv7SP8a6TzDp9OtRENLUB9vndO3BGKPrqA8nwFeoVMpQ5A==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 919, DateTimeKind.Local).AddTicks(8951), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "39a33ae8-2ceb-415c-8fcb-3ddf7bb5f0ed", 0, "e55d6852-4169-4674-84ed-3683e1537ef3", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEI5A0YojyuOvqFz4B5rwcqIOmRJaLQkmxPrMbtbPZuRzkTkGOhvijxiXiD+aZdgtzg==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 551, DateTimeKind.Local).AddTicks(2293), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "4a023c11-a498-41e1-ae27-9888b467fae4", 0, "8f5e043e-5bc5-4fc6-ac65-fcad10575ffc", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEKHxcfr5c/w1jP/wJ98Jv0KpJSLnlICmfk5Bt1EsJTPDYVWZYYTD/CVsJux1yf+fSQ==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 432, DateTimeKind.Local).AddTicks(893), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "7598f124-29ad-4852-bc9f-00ac6a55fe65", 0, "b6604183-2049-4581-8dd6-91c6ca2ddad9", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAELvrD4zHlXz/nhg4x+VgllRj+8Jw8l0Iyg4d0dV1T0mfxg7NoEAw30vHCwCKOZEFZA==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 489, DateTimeKind.Local).AddTicks(4096), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "815d4811-51af-4915-b44e-f3db3506e874", 0, "ac324b84-af9d-4ca8-a20a-df752ebf7a4e", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEIvSk7r5bEkYDXsIg8//EkNcZeSk+umAhNmu9cinRNBGpcUQHka9E5OqwRgT/sGCiQ==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 740, DateTimeKind.Local).AddTicks(7336), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "844517bb-cfd1-47f5-b5a7-35da4fd9917d", 0, "37a7f444-57bd-4157-9d32-cae6b5663e8b", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAELKNSLumSh8hEzfwU+Ncv/iBkeUfASl47sClZMpUy3Kpu2QRQ4Q87Pcs7TqZfAAGDQ==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 610, DateTimeKind.Local).AddTicks(9493), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "df9d6077-a29f-4aa5-bfe6-306a065f57e1", 0, "1172b05a-d98e-4f5d-a307-51c1b539da9d", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEARfefUGUHcZvHvuIcY5xsKK2u3SiCt8nweR2EmrwrCyf2aVb+rDilNymWl4GGnXnw==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 862, DateTimeKind.Local).AddTicks(952), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "e3c40e71-d727-475e-a88c-b52c9c46cc02", 0, "00c517c2-f5b1-498d-a9a1-447a579e4546", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEN0zG2Y7VRcbovQwLY80y1Notz8v5kP7ptB8y+SNI2k/XTU66BR2J6aIrZJ5/OurJg==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 38, 99, DateTimeKind.Local).AddTicks(1460), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "ef7f8fc1-bb50-4479-80d8-bcfaff2dfd4b", 0, "26988fab-a4da-4836-b776-770b9813c3ff", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEAdePyzWG5M57iN6wzoSq1AI6ecmxaqh/tUBi8E4PjUndjndzOOqX2B9Em8yrNggug==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 37, 680, DateTimeKind.Local).AddTicks(1147), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "ffa1329c-4eb0-4060-ab41-a70bd5dcfbb4", 0, "0a6fb22e-ca9e-472f-9172-9d2d2196deef", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEGB37RT3jIQgW37WKwf+5kDk+v4akD8CWGOfQOuKALnvGak5I/t6lNJbP+dT3AOBsg==", null, false, "", new DateTime(2024, 10, 7, 16, 54, 38, 38, DateTimeKind.Local).AddTicks(9295), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "096e855e-f37d-44d5-9ac1-cd9e71bda802" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "29e6c26c-1061-4a8e-bfe0-e159cf780ace" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "356c7c60-ce12-4615-98aa-a7f2208cbca3" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "39a33ae8-2ceb-415c-8fcb-3ddf7bb5f0ed" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4a023c11-a498-41e1-ae27-9888b467fae4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7598f124-29ad-4852-bc9f-00ac6a55fe65" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "815d4811-51af-4915-b44e-f3db3506e874" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "844517bb-cfd1-47f5-b5a7-35da4fd9917d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "df9d6077-a29f-4aa5-bfe6-306a065f57e1" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e3c40e71-d727-475e-a88c-b52c9c46cc02" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ef7f8fc1-bb50-4479-80d8-bcfaff2dfd4b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ffa1329c-4eb0-4060-ab41-a70bd5dcfbb4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "096e855e-f37d-44d5-9ac1-cd9e71bda802" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "29e6c26c-1061-4a8e-bfe0-e159cf780ace" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "356c7c60-ce12-4615-98aa-a7f2208cbca3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "39a33ae8-2ceb-415c-8fcb-3ddf7bb5f0ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4a023c11-a498-41e1-ae27-9888b467fae4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7598f124-29ad-4852-bc9f-00ac6a55fe65" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "815d4811-51af-4915-b44e-f3db3506e874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "844517bb-cfd1-47f5-b5a7-35da4fd9917d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "df9d6077-a29f-4aa5-bfe6-306a065f57e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e3c40e71-d727-475e-a88c-b52c9c46cc02" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ef7f8fc1-bb50-4479-80d8-bcfaff2dfd4b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ffa1329c-4eb0-4060-ab41-a70bd5dcfbb4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "096e855e-f37d-44d5-9ac1-cd9e71bda802");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29e6c26c-1061-4a8e-bfe0-e159cf780ace");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "356c7c60-ce12-4615-98aa-a7f2208cbca3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39a33ae8-2ceb-415c-8fcb-3ddf7bb5f0ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a023c11-a498-41e1-ae27-9888b467fae4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7598f124-29ad-4852-bc9f-00ac6a55fe65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "815d4811-51af-4915-b44e-f3db3506e874");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "844517bb-cfd1-47f5-b5a7-35da4fd9917d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df9d6077-a29f-4aa5-bfe6-306a065f57e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3c40e71-d727-475e-a88c-b52c9c46cc02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef7f8fc1-bb50-4479-80d8-bcfaff2dfd4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffa1329c-4eb0-4060-ab41-a70bd5dcfbb4");

            migrationBuilder.AddColumn<string>(
                name: "ResponsavelTecnico",
                table: "Apis",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Apis",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "0483e647-701b-4930-a3a6-8cca99d8ed3c", 0, "fd61cafb-7ea9-4258-a7ff-3cd47939a513", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAENu5QUQirZuLVk28nPp/6E4aYIqGjuCNn+QQEnjvUeIi+gambIvNQDLEG4TSUHoNBg==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 148, DateTimeKind.Local).AddTicks(5669), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "1a7c95b4-8851-4b28-987e-0c61feb77d1d", 0, "6b2e8cd1-58d4-49f9-be28-168a312c39d9", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEMkCAh0rJpB0LMiT2ZhA2C7hoB67bk0GW9Wz67PuBNTQc+d7CLbNaKe+0yIcUUneRA==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 571, DateTimeKind.Local).AddTicks(1349), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "2cd94bcf-4883-4a30-b077-2f7bc91848ed", 0, "4765c7ea-3458-434d-ade6-0247f8bb1abf", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEJfWNnz9Cvz5CErxwK4t66bfTnp2RoAlElLM3V7r+JoFd1o9QCdU39pWiZ8rKctNGw==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 726, DateTimeKind.Local).AddTicks(3942), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "33c4e333-c141-48eb-81d8-a98cd61880a0", 0, "9686dffa-879a-422a-b0c0-c7156702b33f", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEGqyFKMmxMr/3BB6K3c3Qir//qCyUDTkJc4cVQdLRZ2gyJjSt6MBQfH4lnZ9eTquhA==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 42, 926, DateTimeKind.Local).AddTicks(6351), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "373c7fea-0520-4308-8d37-f1770f117576", 0, "c253fdd8-c77b-4ac9-b0e1-dd0ca02a280f", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAELOZGTNMrhfdVLfFrWzdtFl33+IHw5sFt9P5ZpQlLxkJIVANsiCGwl/m0KNrqN9qZQ==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 654, DateTimeKind.Local).AddTicks(8566), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "43207aee-2889-4ca4-a919-dbb663f9b209", 0, "b3dab08a-ff84-42e1-8a94-48d93984d5a3", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEFd2mWYvh2a+v4zFMT35x52sCvo3xubGT2gUUwmD3q9xDIPBp3LSMmqa4la1nPQ0VQ==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 415, DateTimeKind.Local).AddTicks(3820), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "542e2ebd-0d5a-4211-bf9c-550057de0fad", 0, "ee72b6f9-ccb5-44f0-b43e-229bed3b1a19", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEE+wr49EJfGXgj4Fsqj7KYmvHqNZ1Hm7Gexgn2DNDn+19p2umLLlspzeoac53yOTJw==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 288, DateTimeKind.Local).AddTicks(6169), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "5ae5719b-cab5-427e-9fa3-469e1dc41035", 0, "73fdd49a-172a-4f0c-aec5-eb1a9daf366f", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEPRebsZBeQ0zrCsXKpg+fI7+33Jzj0UKLOv5VBL6cJi2eoCYLfVMXrrFfgiaabQXzw==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 42, 993, DateTimeKind.Local).AddTicks(1623), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "673ce8be-783a-4b8c-88ce-31cd11bcc76d", 0, "74494507-2686-47c3-a8a3-c014854426ef", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEIdMM7sJdVFZyoJJKV9PJDZpDLhdhiaGlAF/aVKN75qEh8sPGOnG9KlYqBI8wlBKMA==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 482, DateTimeKind.Local).AddTicks(2033), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "c2328c59-a5db-4756-8800-512bf17ab76a", 0, "9b8ee84a-5f66-484f-850c-a45ea571936f", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEM12iCDW35rTfla+NfRjMwwsS37plWc3iieRXh0BJpTck74B/JRXFwFPOo1Dj6N0QA==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 63, DateTimeKind.Local).AddTicks(6962), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "da20ee8d-2d64-4b94-9eb4-f0aadefd8d9e", 0, "5afc995f-a4e2-43b8-be68-f246a0e4394d", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAED1oBwfgNojwz+whPnFxQoYjDB31jbDB8RxtKMH+6GsOf9LDJy3nAqGpr16Z4+vIng==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 215, DateTimeKind.Local).AddTicks(2810), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "e8e408b5-86b5-424f-b8df-ca946ba83970", 0, "75c3c1ed-4b2d-4044-875d-dd369792b3ec", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEDxd2SyVILB99QU1Kq57ypDKJ4pyvtSooIHWMMMw4HF/FODQqEs2lHqx3Z0MDS+aBA==", null, false, "", new DateTime(2024, 10, 7, 16, 51, 43, 352, DateTimeKind.Local).AddTicks(8723), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0483e647-701b-4930-a3a6-8cca99d8ed3c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1a7c95b4-8851-4b28-987e-0c61feb77d1d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2cd94bcf-4883-4a30-b077-2f7bc91848ed" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "33c4e333-c141-48eb-81d8-a98cd61880a0" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "373c7fea-0520-4308-8d37-f1770f117576" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "43207aee-2889-4ca4-a919-dbb663f9b209" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "542e2ebd-0d5a-4211-bf9c-550057de0fad" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5ae5719b-cab5-427e-9fa3-469e1dc41035" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "673ce8be-783a-4b8c-88ce-31cd11bcc76d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c2328c59-a5db-4756-8800-512bf17ab76a" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "da20ee8d-2d64-4b94-9eb4-f0aadefd8d9e" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e8e408b5-86b5-424f-b8df-ca946ba83970" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apis_UserId",
                table: "Apis",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apis_AspNetUsers_UserId",
                table: "Apis",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

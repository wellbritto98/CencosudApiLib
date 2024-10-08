using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class removeresponsaveltecnico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0a899995-7183-4c05-b989-888f3fc3ba42" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2008491f-d4f7-475b-b3e2-6dea11796fcc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "369a1880-a73d-4630-a2b0-a4d3e86b6071" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "40c66152-5a80-4605-a7f8-c2da1d80ade7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4f9188c1-89ef-433e-9194-6caf0f204b6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "55438839-58e1-4482-a020-1ba0032d6948" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5cad271a-3af7-4cf8-9d06-88ac571d83da" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a9ee6bf7-2fed-4f73-acda-38edc392a185" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "aabe168f-5eb2-4389-ad3a-e8d2592a6d8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "aada8d36-fcfd-44f1-8661-87cf484f2447" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d35c2b7a-de9d-4659-90b6-5167cbd6309c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d9ada38b-9546-4a06-8c47-335a52326026" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a899995-7183-4c05-b989-888f3fc3ba42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2008491f-d4f7-475b-b3e2-6dea11796fcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "369a1880-a73d-4630-a2b0-a4d3e86b6071");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40c66152-5a80-4605-a7f8-c2da1d80ade7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f9188c1-89ef-433e-9194-6caf0f204b6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55438839-58e1-4482-a020-1ba0032d6948");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cad271a-3af7-4cf8-9d06-88ac571d83da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ee6bf7-2fed-4f73-acda-38edc392a185");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aabe168f-5eb2-4389-ad3a-e8d2592a6d8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aada8d36-fcfd-44f1-8661-87cf484f2447");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d35c2b7a-de9d-4659-90b6-5167cbd6309c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9ada38b-9546-4a06-8c47-335a52326026");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "0a899995-7183-4c05-b989-888f3fc3ba42", 0, "24388e8b-592c-46a3-9994-c2d0724d87f9", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEESAUJErqaramIxU3ZCsl1vgv0Ytrivfw8OvTcUjhNBh4J45qSPZZBtIA+6M598giA==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 539, DateTimeKind.Local).AddTicks(1159), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "2008491f-d4f7-475b-b3e2-6dea11796fcc", 0, "17fa7fe9-1e4d-412b-9a6a-1d6142417c05", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEENTvATs2vSK3Clg2JHCXYEL7dTnaDmUEeOYUEHmLeCLTtqmu7ie1ilEn4ZZr6dIUA==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 196, DateTimeKind.Local).AddTicks(4441), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "369a1880-a73d-4630-a2b0-a4d3e86b6071", 0, "bee0bcab-4f3c-4beb-a808-2968aa636b63", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEK4j3ZQM+E9RU8jTt605R4+mg/dW3ZCzQKJe9KjJJ8k0nWV/yXNmtCoULzAERAx6UQ==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 324, DateTimeKind.Local).AddTicks(8598), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "40c66152-5a80-4605-a7f8-c2da1d80ade7", 0, "019f2ccf-c1ac-4fa0-b8b4-28419e0c6607", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEOc2Ke+weJTb1q5RKcZRk8CxotlbwTksbqG2cWpIOnQflyYaadj1D0yxAXikYwTJdA==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 256, DateTimeKind.Local).AddTicks(7995), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "4f9188c1-89ef-433e-9194-6caf0f204b6d", 0, "3cf1a85f-f6dd-42c0-8c06-e13552f9c2ca", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEOgW0zh4dNyUecccNC6jQ5jAVei9x9EiqX5BsTtLig+B1y6pT4fpTyjVgrIgb4i+YA==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 137, DateTimeKind.Local).AddTicks(4150), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "55438839-58e1-4482-a020-1ba0032d6948", 0, "ed001650-9905-43d8-b4c7-68914af0672b", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEED1MEJz7jHLQcCn+bdpiF1xvJL9igEyN54DN6xzj//S6m48xiJwCOhQEpmCfOcBdw==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 654, DateTimeKind.Local).AddTicks(5677), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "5cad271a-3af7-4cf8-9d06-88ac571d83da", 0, "2ee3f431-7afd-4632-a570-fbef0eb1929f", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAECOGufy/BkeWGgNw6D60e2uC9+vq/2Py4xpwx7ZR/xA+70kpXebmBaFd4ALvV/qZ9g==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 58, DateTimeKind.Local).AddTicks(5637), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "a9ee6bf7-2fed-4f73-acda-38edc392a185", 0, "035beb4c-4c70-4221-bd40-273ff82db281", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEGLVl37rRDf0cYgWOLLlj4mHRUXKKDEZ8bmyP1zCkSez8GFfINX9gL1PIe/KsbK5Jg==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 412, DateTimeKind.Local).AddTicks(4130), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "aabe168f-5eb2-4389-ad3a-e8d2592a6d8b", 0, "2a60a7de-c00f-4752-a00d-d3bf538cbaf7", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEA6Ft4LRiqrKIc7BQLD40EiVlaMRV6siUEk/ITI3otyZJ11WaqiitT4JWTOUO+FMjg==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 23, 995, DateTimeKind.Local).AddTicks(988), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "aada8d36-fcfd-44f1-8661-87cf484f2447", 0, "8f424135-8366-417d-97b7-15d5a1550cd5", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEO3HiEfXaDrB1GnwVZE6esORgmuXh/g9na1eBGfsKvExj6P49tHE+3jpnvl5rL7LRw==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 480, DateTimeKind.Local).AddTicks(6687), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "d35c2b7a-de9d-4659-90b6-5167cbd6309c", 0, "ebff0e34-f755-4e82-bd7c-9f32f37847d5", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEDnUbm+ptDps2P3u+QVq7khGm+xCF63D7zLldkmCu5z7OGwuB5xCxzHcb0wxBhyMFg==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 714, DateTimeKind.Local).AddTicks(6488), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "d9ada38b-9546-4a06-8c47-335a52326026", 0, "3e3bd0d5-239c-4d99-906b-df9485040a99", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEKZI2ZisVjtX28ZPMeAxEncDLpjMlhIm5UHUCM61ftZtH/FLJuJrG/+7XO8PoAhoBQ==", null, false, "", new DateTime(2024, 10, 7, 16, 48, 24, 596, DateTimeKind.Local).AddTicks(6591), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0a899995-7183-4c05-b989-888f3fc3ba42" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2008491f-d4f7-475b-b3e2-6dea11796fcc" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "369a1880-a73d-4630-a2b0-a4d3e86b6071" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "40c66152-5a80-4605-a7f8-c2da1d80ade7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4f9188c1-89ef-433e-9194-6caf0f204b6d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "55438839-58e1-4482-a020-1ba0032d6948" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5cad271a-3af7-4cf8-9d06-88ac571d83da" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a9ee6bf7-2fed-4f73-acda-38edc392a185" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "aabe168f-5eb2-4389-ad3a-e8d2592a6d8b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "aada8d36-fcfd-44f1-8661-87cf484f2447" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d35c2b7a-de9d-4659-90b6-5167cbd6309c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d9ada38b-9546-4a06-8c47-335a52326026" }
                });
        }
    }
}

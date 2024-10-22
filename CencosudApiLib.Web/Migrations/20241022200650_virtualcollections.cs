using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class virtualcollections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "25e3f31a-54c0-44f7-a9f6-1f177437e1fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "31023165-d569-4db9-a841-755d8e648b19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "36263acc-0b35-4d6f-9962-eeb7181944fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9f6d91fd-e4e9-4842-899c-159cb1678680" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a4991da2-52d2-4166-a3c8-5f092b4d321d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a81809e0-9fab-47b0-9ab3-edb6e3dc1be7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ac0db34a-1984-4c2e-b2ac-cc08b557df4f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b0d6f3db-13e1-4f0d-8f8d-21cf398cb101" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d0b2bfc9-9925-4e86-b73a-6036cfa8b662" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "db8ac11a-08ed-44e9-9ddf-50b1624cae3c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "df569148-5588-48d4-8571-fe76e14a7c52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f0048926-d905-474b-a1e2-1c7fcd84258c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25e3f31a-54c0-44f7-a9f6-1f177437e1fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31023165-d569-4db9-a841-755d8e648b19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36263acc-0b35-4d6f-9962-eeb7181944fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f6d91fd-e4e9-4842-899c-159cb1678680");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4991da2-52d2-4166-a3c8-5f092b4d321d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a81809e0-9fab-47b0-9ab3-edb6e3dc1be7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac0db34a-1984-4c2e-b2ac-cc08b557df4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0d6f3db-13e1-4f0d-8f8d-21cf398cb101");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0b2bfc9-9925-4e86-b73a-6036cfa8b662");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db8ac11a-08ed-44e9-9ddf-50b1624cae3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df569148-5588-48d4-8571-fe76e14a7c52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0048926-d905-474b-a1e2-1c7fcd84258c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "049736d8-08dd-42e8-8f7f-0ccf33fda2a0", 0, "4d91c3bc-5f86-42e8-8caf-bc6b5e8f697d", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEODNrb1NeiUU3wBTd4vlzY4bbbjM4l6v2rUg3rJSyf+AyF0M6X7T3LXyh4xiOBm2ug==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 49, 105, DateTimeKind.Local).AddTicks(1111), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "08ff4386-4ffb-469b-8029-0c2c1b8d2731", 0, "86db31fd-899c-48aa-99fc-afc2ba965775", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEOVMKAdCmsJ/d9sZ65CF1ajxv3QzPadGNnAZxmzZnom9jPxfw/B8DYdmUgR3R+dWbw==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 48, 976, DateTimeKind.Local).AddTicks(4829), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "0c62881e-ba00-4c93-97df-debbd2be7d47", 0, "e98c309a-a583-4924-975a-f317763a9988", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEKpGLui5PLEbXTi2RYADLcsJjPGqjq8XmcZc3/X2CSUrqj/wIsRTxCUbmk0aFyQ1YA==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 48, 795, DateTimeKind.Local).AddTicks(5544), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "2123f97b-0e8a-41c9-b8da-9a4094c6ba7f", 0, "c2c5a935-5141-428e-89ca-0abee40f4337", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEOY39Eoo0GIw0BZ/y4IZ/ZfnNZV3yhKrYhbWM+ZyUkhb8Xyk22JiEtF9qJI0LLiKOQ==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 49, 453, DateTimeKind.Local).AddTicks(8105), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "25e4c653-a587-4631-94b8-3caad5eae89d", 0, "f3ad313d-7473-48bc-8688-cc08b10ec268", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEMBSy+1DnnYEUStEgxFt50lxP/GIzdawFS/68+ay175ZyR+r9CqgtgWF3oeDQAUYqg==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 49, 224, DateTimeKind.Local).AddTicks(7452), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "4b870b8a-0296-40a1-a784-515fb5510083", 0, "af7dc4d6-08d2-4625-87b2-8659fe562b43", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEOdUlIh/Y8+7QHnNfYEHhqAZTnMsYIrR62RkrjJHKZiBCQP9CQDc/IJ4GHCufQ7U+A==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 49, 337, DateTimeKind.Local).AddTicks(4552), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "8a1ea4d9-679b-4c9d-aa3e-73bf2231a0a1", 0, "d39ccf9a-94f8-4f6c-9633-0aec4c3ebc4b", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAELB/fA46xgZDmasA2apNAPZS93dcHPHlH2XbJo4k62q5ABVryckfHzV8JK+F3qETgA==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 48, 915, DateTimeKind.Local).AddTicks(615), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "9559a1b1-58f3-42ba-a729-cb7afad6707a", 0, "1a2a8261-b772-4f9a-a6da-90eaa298130e", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEFc9G8owP6mDszzGxayhfRif2kcEeps4CUCVq65l0SposVb2AECLvzndH5Doaj4vAQ==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 49, 281, DateTimeKind.Local).AddTicks(640), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "a92fb399-8707-4bde-a85b-9216c852fbe4", 0, "919317b8-7e00-47c9-8f09-07dcb0c38afd", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEFOauU3MAf56xWfHBuMaCySDGKbNt9mP9KD6xsoHiIOBtcxbVNLFMKewp2b5CJdWnQ==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 49, 396, DateTimeKind.Local).AddTicks(2244), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "b78ea2e3-fbf9-46e7-b141-c55d8f1cf624", 0, "71805d63-0d44-4b66-b94e-2fcfbe0be4db", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAELuNhRlYEoI5cpBEzOmOkdjTBJBwgyfS1WgF+BPdMr6JM4HfaJPPyhtxaeVJR+Yl7g==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 48, 853, DateTimeKind.Local).AddTicks(8650), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "b7f0c236-4ca9-4b41-89b1-8d4e7d537dd7", 0, "8b2597cc-e1da-4b9d-a841-abb7c900ee21", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEFbj4VFlhUF/6jShopYJ2EiAdhnduChC0BVDavi/kTaBKTUD6TFgok+SozGPP0q2cA==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 49, 164, DateTimeKind.Local).AddTicks(283), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "f6129a13-0886-4283-96ac-637f3ad40ced", 0, "e80bdf61-5b7b-4dae-ad62-e603d8a9495a", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEDVNY/PE8dBCspmPX4hXzPTgglpBnxfZn6wiLsIuBt8nk/IZIavbOfqoKkXBxVKUlA==", null, false, "", new DateTime(2024, 10, 22, 17, 6, 49, 47, DateTimeKind.Local).AddTicks(4275), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "049736d8-08dd-42e8-8f7f-0ccf33fda2a0" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "08ff4386-4ffb-469b-8029-0c2c1b8d2731" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0c62881e-ba00-4c93-97df-debbd2be7d47" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2123f97b-0e8a-41c9-b8da-9a4094c6ba7f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "25e4c653-a587-4631-94b8-3caad5eae89d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4b870b8a-0296-40a1-a784-515fb5510083" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8a1ea4d9-679b-4c9d-aa3e-73bf2231a0a1" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9559a1b1-58f3-42ba-a729-cb7afad6707a" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a92fb399-8707-4bde-a85b-9216c852fbe4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b78ea2e3-fbf9-46e7-b141-c55d8f1cf624" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b7f0c236-4ca9-4b41-89b1-8d4e7d537dd7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f6129a13-0886-4283-96ac-637f3ad40ced" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "049736d8-08dd-42e8-8f7f-0ccf33fda2a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "08ff4386-4ffb-469b-8029-0c2c1b8d2731" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0c62881e-ba00-4c93-97df-debbd2be7d47" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2123f97b-0e8a-41c9-b8da-9a4094c6ba7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "25e4c653-a587-4631-94b8-3caad5eae89d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4b870b8a-0296-40a1-a784-515fb5510083" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8a1ea4d9-679b-4c9d-aa3e-73bf2231a0a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9559a1b1-58f3-42ba-a729-cb7afad6707a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a92fb399-8707-4bde-a85b-9216c852fbe4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b78ea2e3-fbf9-46e7-b141-c55d8f1cf624" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b7f0c236-4ca9-4b41-89b1-8d4e7d537dd7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f6129a13-0886-4283-96ac-637f3ad40ced" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "049736d8-08dd-42e8-8f7f-0ccf33fda2a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08ff4386-4ffb-469b-8029-0c2c1b8d2731");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c62881e-ba00-4c93-97df-debbd2be7d47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2123f97b-0e8a-41c9-b8da-9a4094c6ba7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25e4c653-a587-4631-94b8-3caad5eae89d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b870b8a-0296-40a1-a784-515fb5510083");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a1ea4d9-679b-4c9d-aa3e-73bf2231a0a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9559a1b1-58f3-42ba-a729-cb7afad6707a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a92fb399-8707-4bde-a85b-9216c852fbe4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b78ea2e3-fbf9-46e7-b141-c55d8f1cf624");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7f0c236-4ca9-4b41-89b1-8d4e7d537dd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6129a13-0886-4283-96ac-637f3ad40ced");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "25e3f31a-54c0-44f7-a9f6-1f177437e1fa", 0, "00efa79a-43db-4ef6-af22-25d2f2c30fa5", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEO35jeLFdGELpI1ddRBwO2DyjL1k6//7Ezs3Dzxu0chuR07cfA7xaPWBF4elnMetrg==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 27, 991, DateTimeKind.Local).AddTicks(6714), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "31023165-d569-4db9-a841-755d8e648b19", 0, "cb8307d1-96b5-4a4e-96ac-a218e984f9c2", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAENnnPZq9hRn6LTRCDRMTWS1MZnZ6u2+INrmTmACpRIYmTW4dcZC1YSSq0yGlmY98zg==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 28, 502, DateTimeKind.Local).AddTicks(8967), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "36263acc-0b35-4d6f-9962-eeb7181944fd", 0, "c405f366-0aac-4537-8a61-321c3892ffab", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEF4tgBYvKbLRMzsUJJH1L+/U/V6VYNEifjKivwcYDMEC6miVa/3BolWrXgXa9i09PA==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 27, 785, DateTimeKind.Local).AddTicks(270), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "9f6d91fd-e4e9-4842-899c-159cb1678680", 0, "5d3c43e3-2c80-4f91-8168-9cefdb1b13ae", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEBCYZPUcSQ23tXr3T6ecJl/8X6AAiEYKJRHZNLTfEtWoxefd9no5riO7IJNCfpXfQA==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 28, 444, DateTimeKind.Local).AddTicks(7202), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "a4991da2-52d2-4166-a3c8-5f092b4d321d", 0, "5555829b-af0f-4543-98ed-c497e3d0acc2", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAENbQDcZG4k877PVJVe4hjkxyXvVPGPETRhvRf5fot6UDDdTf+Lxzj3mrPqRnNwcl9w==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 27, 917, DateTimeKind.Local).AddTicks(2407), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "a81809e0-9fab-47b0-9ab3-edb6e3dc1be7", 0, "246ddb66-265a-4b32-a03c-eec0f8de01f3", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEHCPaBuRhCb3wu0/aTu5RfAlvncaIA0TADQcx1kGLWRgiLVifssuyc4SI/ccIe4LdQ==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 28, 314, DateTimeKind.Local).AddTicks(4092), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "ac0db34a-1984-4c2e-b2ac-cc08b557df4f", 0, "ab48de7a-26d2-48b6-8681-d38c5e827b14", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEMzNl6JbiIL6Mg8QZl2Hp97IEdwZhKLxcniz9EPFMGxEGFT3+SG7h1LJLy3/yUNu8A==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 28, 373, DateTimeKind.Local).AddTicks(2375), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "b0d6f3db-13e1-4f0d-8f8d-21cf398cb101", 0, "0ef67cfd-27a3-46ad-b7c1-27e9b7173614", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEHWUdSpJKqvQoQRRNFlFlKFbVCPw06rwr3zN1ZRjJKbuzgjPo43H9B65jN2e/jJeLA==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 28, 120, DateTimeKind.Local).AddTicks(5336), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "d0b2bfc9-9925-4e86-b73a-6036cfa8b662", 0, "8e4f36ef-b11c-40b5-8a79-b4893d9ca3ff", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEJRi6UXvlOxdjlGX9U4d/Bsg31xmmsUYI69ek8PChwTGfvTVO4KFmi3KCmh3cHKUpg==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 28, 186, DateTimeKind.Local).AddTicks(214), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "db8ac11a-08ed-44e9-9ddf-50b1624cae3c", 0, "ea876d91-36d5-4d3e-9209-cd08ea81c40c", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEOAvr7pHls3xrrCENBoIjT+Tqo8z64EDZ+JoiubBTRrpHu2Cg2FoT8nZwzI0mvn8sA==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 27, 843, DateTimeKind.Local).AddTicks(7677), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "df569148-5588-48d4-8571-fe76e14a7c52", 0, "5da01bf6-33e0-4f2e-ac60-1d7a24ac6e27", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEFdsVdcGMRqv+Xai+P+N2hDlr3NlEKhv7G5mEDbJmUUdLWTyVIAUEXkbY3+HsQyX0g==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 28, 245, DateTimeKind.Local).AddTicks(5300), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "f0048926-d905-474b-a1e2-1c7fcd84258c", 0, "6cbf043b-6574-457a-8aeb-df486a88f148", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEJTpJLbQNIFNY1um/SKjF6ix2Z0qcWeCdhw2n+Auxr76yULEKSjEriz3oOWPYR3A1w==", null, false, "", new DateTime(2024, 10, 15, 12, 37, 28, 59, DateTimeKind.Local).AddTicks(5441), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "25e3f31a-54c0-44f7-a9f6-1f177437e1fa" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "31023165-d569-4db9-a841-755d8e648b19" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "36263acc-0b35-4d6f-9962-eeb7181944fd" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9f6d91fd-e4e9-4842-899c-159cb1678680" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a4991da2-52d2-4166-a3c8-5f092b4d321d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a81809e0-9fab-47b0-9ab3-edb6e3dc1be7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ac0db34a-1984-4c2e-b2ac-cc08b557df4f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b0d6f3db-13e1-4f0d-8f8d-21cf398cb101" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d0b2bfc9-9925-4e86-b73a-6036cfa8b662" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "db8ac11a-08ed-44e9-9ddf-50b1624cae3c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "df569148-5588-48d4-8571-fe76e14a7c52" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f0048926-d905-474b-a1e2-1c7fcd84258c" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class cencosudfirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0bc51b55-0352-4a15-a43d-83e75e98aa8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1feed60c-34bc-4d16-81fe-980fc25f408f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "224bc834-908f-492b-878d-1005b9f2ae51" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3c76221e-d810-4637-ba3b-2a932bbd4ac7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4774afae-a7fa-47cd-8dd9-19b0e0107fa8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "569b4aac-8008-4d64-8e46-4eea60daca90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5b23679e-c520-4077-9101-2c40797f5a39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7d1e29cc-c829-4cd5-afb3-6fc5e59eb9e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8bb17cea-f1a4-4278-b2d0-932f3af15425" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "974c3b43-38f2-4c13-b232-41f11b6c4e6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d135cbf1-ecca-4b33-9031-f6af2df6c59f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fcbce295-a7cf-44cb-b73f-b73aa240bfa6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bc51b55-0352-4a15-a43d-83e75e98aa8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1feed60c-34bc-4d16-81fe-980fc25f408f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224bc834-908f-492b-878d-1005b9f2ae51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c76221e-d810-4637-ba3b-2a932bbd4ac7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4774afae-a7fa-47cd-8dd9-19b0e0107fa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569b4aac-8008-4d64-8e46-4eea60daca90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b23679e-c520-4077-9101-2c40797f5a39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d1e29cc-c829-4cd5-afb3-6fc5e59eb9e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bb17cea-f1a4-4278-b2d0-932f3af15425");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "974c3b43-38f2-4c13-b232-41f11b6c4e6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d135cbf1-ecca-4b33-9031-f6af2df6c59f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcbce295-a7cf-44cb-b73f-b73aa240bfa6");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "0bc51b55-0352-4a15-a43d-83e75e98aa8b", 0, "807f41e1-f66f-4123-a395-fef7e4165550", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEK15XCnBPJaIpXIbOqkltq2WSa/4bt1oS5+4b9F7ViG+ms2dWyfw0EM98nTHSDv1Eg==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 667, DateTimeKind.Local).AddTicks(3561), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "1feed60c-34bc-4d16-81fe-980fc25f408f", 0, "c5a20853-076b-4ed9-999b-c9bc4e78b0ca", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEGApVl613z3De+0RrXKvkycac2K5HGi8EOsHgrTCHuJmMeDC1Z9UIsVrHAYA1zOVbg==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 126, DateTimeKind.Local).AddTicks(7749), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "224bc834-908f-492b-878d-1005b9f2ae51", 0, "268ecd6e-ff2d-4daf-8c6f-9f130c0104a6", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEOsMJASKZvBg0hnUZqwMizD1XEml2MrAFz0YoxZo8UrDf3BUKdTKmPn6D8q0h1OpUQ==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 791, DateTimeKind.Local).AddTicks(4261), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "3c76221e-d810-4637-ba3b-2a932bbd4ac7", 0, "17a4434d-8798-4be1-9837-8ef3823e477f", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEHANycTip7zZc7gdMrt6UbcRAn/kAIFypY6/2mReTCLfh4imm6phCcgQ8j6D7D8ApA==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 287, DateTimeKind.Local).AddTicks(852), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "4774afae-a7fa-47cd-8dd9-19b0e0107fa8", 0, "9685e8da-a4e1-4233-910b-20de878f2e39", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEC1UdwZ39Htck0y7droKfvho5IdvG93fcIs6oigNC6nls5OGC4Ri8zT+tJtJC60oSA==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 204, DateTimeKind.Local).AddTicks(1365), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "569b4aac-8008-4d64-8e46-4eea60daca90", 0, "0c5e8160-ce88-46c6-be48-93c770ed8b09", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEFDhJ7MvMiqzaqS4LLl0+VHvGTEl6JvUmXHI90QFpX039B6MVtt6qetajM3nc/eHmw==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 427, DateTimeKind.Local).AddTicks(8449), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "5b23679e-c520-4077-9101-2c40797f5a39", 0, "607d35a3-0410-4868-a45b-ac1b74bbd0b6", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEG21qZaley+v7pd7SLwEiB5e0hlArbNDiK3VjJ18aEf0RECnzY8H/jN6kA0RYewGgg==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 729, DateTimeKind.Local).AddTicks(4151), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "7d1e29cc-c829-4cd5-afb3-6fc5e59eb9e2", 0, "103da31c-8150-4ab9-a0d8-0212a240edc5", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEBCtfNpRi4Bm3iE5QZTPieqIYbKnyJk/QZM1ppg4FpZsriIdnX8NbibbcgSXhEjdpQ==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 609, DateTimeKind.Local).AddTicks(9574), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "8bb17cea-f1a4-4278-b2d0-932f3af15425", 0, "81baa555-3e4f-4a98-afce-1cc6d48dfd85", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEKBD06phzs5Xu4AkbjzvSEJGXLsD7KTn6lTL3s29HVm4N4Fsbq1XYLB9EAJ9r31ggw==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 490, DateTimeKind.Local).AddTicks(9022), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "974c3b43-38f2-4c13-b232-41f11b6c4e6d", 0, "3ec4e2a3-16bd-4ed2-a543-2b5a98016ad7", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEP9uvQ5jhZNaw4KZbDa2cIj1LTht7+U2qi8b43d67s/G5bLmJ9sUN7iA5cGlJSBvqQ==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 364, DateTimeKind.Local).AddTicks(524), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "d135cbf1-ecca-4b33-9031-f6af2df6c59f", 0, "5895e034-37c2-4b76-a58e-24690ffacb45", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEMe4AEC8JSNw/o/eDPNx38/6Y0Zrx07PYtDmYs6BXvZ73U3WxA19OqCHzfTooxw9hw==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 36, DateTimeKind.Local).AddTicks(2233), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "fcbce295-a7cf-44cb-b73f-b73aa240bfa6", 0, "eb9a85c3-459b-4d67-a0c1-1a9f72896017", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEMfwS/zeZQc3rZsJ/aEil+uciGipK/rDzNSJFkTQoAkpqN+w5gxIK4Uyw44B96vjVA==", null, false, "", new DateTime(2024, 10, 7, 16, 57, 51, 551, DateTimeKind.Local).AddTicks(8694), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0bc51b55-0352-4a15-a43d-83e75e98aa8b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1feed60c-34bc-4d16-81fe-980fc25f408f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "224bc834-908f-492b-878d-1005b9f2ae51" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3c76221e-d810-4637-ba3b-2a932bbd4ac7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4774afae-a7fa-47cd-8dd9-19b0e0107fa8" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "569b4aac-8008-4d64-8e46-4eea60daca90" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5b23679e-c520-4077-9101-2c40797f5a39" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7d1e29cc-c829-4cd5-afb3-6fc5e59eb9e2" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8bb17cea-f1a4-4278-b2d0-932f3af15425" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "974c3b43-38f2-4c13-b232-41f11b6c4e6d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d135cbf1-ecca-4b33-9031-f6af2df6c59f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fcbce295-a7cf-44cb-b73f-b73aa240bfa6" }
                });
        }
    }
}

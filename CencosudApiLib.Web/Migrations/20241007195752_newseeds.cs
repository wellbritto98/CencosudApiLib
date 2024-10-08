using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class newseeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Apis",
                columns: new[] { "Id", "BaseUrl", "Description", "IsDeleted", "Name", "Version" },
                values: new object[,]
                {
                    { 1, "https://auth.api.com", "API for user authentication", false, "Authentication API", "v1.0" },
                    { 2, "https://payment.api.com", "API for payment processing", false, "Payment API", "v2.1" },
                    { 3, "https://notify.api.com", "API for sending notifications", false, "Notification API", "v1.3" }
                });

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
                table: "Projects",
                columns: new[] { "Id", "Description", "IsDeleted", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "A platform for online shopping", false, "E-Commerce Platform", "Active" },
                    { 2, "System to manage internal APIs", false, "Internal API Management", "Development" },
                    { 3, "Mobile application for managing orders", false, "Mobile App", "Testing" }
                });

            migrationBuilder.InsertData(
                table: "ApiInstances",
                columns: new[] { "ApiId", "ProjectId", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, false },
                    { 2, 1, false },
                    { 1, 2, false },
                    { 3, 2, false },
                    { 3, 3, false }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApiInstances",
                keyColumns: new[] { "ApiId", "ProjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ApiInstances",
                keyColumns: new[] { "ApiId", "ProjectId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ApiInstances",
                keyColumns: new[] { "ApiId", "ProjectId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ApiInstances",
                keyColumns: new[] { "ApiId", "ProjectId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ApiInstances",
                keyColumns: new[] { "ApiId", "ProjectId" },
                keyValues: new object[] { 3, 3 });

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
                table: "Apis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Apis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Apis",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class usingenums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Projects",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "2e584b38-8510-4fe3-a78b-0b7a05f31845", 0, "02061551-580f-4a91-ba00-17f41728c22a", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEGgrj3uqpYE1JIKsDtgAv8C8cKo9kWqBGA/R92TJbKtOL9kOaEZiUs2FxV7UJeYKww==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 641, DateTimeKind.Local).AddTicks(3005), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "3f101938-1087-48b2-8404-3bf581bb561b", 0, "bb8b638c-00a2-4525-8222-9394f4088a93", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEFHPlbRVeOz0Uge7idKjwCkPaaTnfmcH9ZpK6+pikAEoYV9L578q6Y6JvEKtxM3YYg==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 384, DateTimeKind.Local).AddTicks(2945), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "447dd844-9eac-46fe-9a9c-46a5b4bc2367", 0, "9f99eafc-3c2f-4753-83e8-adcce58e5666", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEDpsp3kE4D0DW7AZHiFXOmBKcBNEp9I1a+p13XD9h6Z6JgRCOBuuB7YbAamzxc8O0Q==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 235, DateTimeKind.Local).AddTicks(5939), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "553ece2f-e954-461f-a395-d3e16fd33a71", 0, "645efdfd-ac74-4fc9-8df8-9618cf88df6e", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEMdvqbBR3eHhWS8d8KHepAZGvIdeodg0pk76U6+C01FiGT6l04ASgEwMnVfT/BewFA==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 762, DateTimeKind.Local).AddTicks(4805), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "6cde67a6-f240-4d65-ae08-ff1226755cf2", 0, "b5f223f8-af59-4a70-a25f-8102e521416b", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAENoRIyh/5tkalg3SjL5WBzH9UTKD2pqFSd40+4bzCjBfYXRVE16J1kDMGrwjPL8sbg==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 303, DateTimeKind.Local).AddTicks(7368), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "721269ef-36f8-45bd-b445-4bc8adcebb69", 0, "6b243edb-f771-4b20-82b6-90d6ef72fde7", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAENlqNvumv/VFyy47NSOGgVl5PJNgP0YujJUieqQdeysBQ8QQESkLPzCpWn15fEvXdg==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 167, DateTimeKind.Local).AddTicks(7846), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "836a0cfb-3328-41fd-8b2f-2e3503d2aab1", 0, "2479abf4-4132-4eaf-91bb-cd348c66b0e5", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEPn017avT3deNg0CW+sxQMnSns59I3kfQryw+p0lVC04FTQs+31fGyX5dmKGYW+vDw==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 701, DateTimeKind.Local).AddTicks(7173), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "93b24842-5bbf-45da-932d-bcabc5130d33", 0, "8fc8f6af-38b8-4892-af4b-68c8399da644", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEPXlQQaabS1l7Iu8nfpnCCEESrKbBlDQ/TSABiR1UtCEgyaOMlqk1oNviGzVOlmZ2g==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 519, DateTimeKind.Local).AddTicks(6125), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "a418ed40-b4b5-4713-bcb2-0c7bb1b193c6", 0, "75686896-9720-497a-bbe1-b8eee06d4bca", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEAmDyGY4R8h20uzaTfxcBtO/6xeV0ES8IoqjkYQ+crcaQtkjwNIFcKvg6qDYXEQd3Q==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 106, DateTimeKind.Local).AddTicks(6620), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "d3fc89b7-3c7e-47bd-8625-b8dad06b1692", 0, "5197659b-358f-4f31-9dc7-c39bdca90ef6", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEDlFFv7fatX0VFgjRwVyukVE+kbian77iXioUqRct/YXFl332jUe/wYcKKY87SnWBw==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 458, DateTimeKind.Local).AddTicks(9014), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "d5e24750-cf91-45df-8562-f30f54a518d0", 0, "f0c5448a-9a6e-43ee-b6cc-9205d2e57290", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEMU8K8oW4HjRH91F11fN/gkIEMnAvhufhPhhg7CEDqDuq0zdF8PSazx+lBJgFDUGSw==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 581, DateTimeKind.Local).AddTicks(9672), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "e653f7c5-47af-4024-9543-97ee7a0c27a4", 0, "8e0ed2eb-05be-4f09-9986-f94246e69139", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEFK6CRROU5pKomIqIOLjXkX1HkLlDRgFWz4j2FKxFv6y8+Fc9kBiQZ0qyaW/B8sZvA==", null, false, "", new DateTime(2024, 11, 1, 16, 0, 49, 47, DateTimeKind.Local).AddTicks(1617), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "A");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "D");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "C");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2e584b38-8510-4fe3-a78b-0b7a05f31845" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3f101938-1087-48b2-8404-3bf581bb561b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "447dd844-9eac-46fe-9a9c-46a5b4bc2367" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "553ece2f-e954-461f-a395-d3e16fd33a71" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6cde67a6-f240-4d65-ae08-ff1226755cf2" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "721269ef-36f8-45bd-b445-4bc8adcebb69" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "836a0cfb-3328-41fd-8b2f-2e3503d2aab1" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "93b24842-5bbf-45da-932d-bcabc5130d33" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a418ed40-b4b5-4713-bcb2-0c7bb1b193c6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d3fc89b7-3c7e-47bd-8625-b8dad06b1692" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d5e24750-cf91-45df-8562-f30f54a518d0" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e653f7c5-47af-4024-9543-97ee7a0c27a4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2e584b38-8510-4fe3-a78b-0b7a05f31845" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3f101938-1087-48b2-8404-3bf581bb561b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "447dd844-9eac-46fe-9a9c-46a5b4bc2367" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "553ece2f-e954-461f-a395-d3e16fd33a71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6cde67a6-f240-4d65-ae08-ff1226755cf2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "721269ef-36f8-45bd-b445-4bc8adcebb69" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "836a0cfb-3328-41fd-8b2f-2e3503d2aab1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "93b24842-5bbf-45da-932d-bcabc5130d33" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a418ed40-b4b5-4713-bcb2-0c7bb1b193c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d3fc89b7-3c7e-47bd-8625-b8dad06b1692" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d5e24750-cf91-45df-8562-f30f54a518d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e653f7c5-47af-4024-9543-97ee7a0c27a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e584b38-8510-4fe3-a78b-0b7a05f31845");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f101938-1087-48b2-8404-3bf581bb561b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "447dd844-9eac-46fe-9a9c-46a5b4bc2367");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "553ece2f-e954-461f-a395-d3e16fd33a71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cde67a6-f240-4d65-ae08-ff1226755cf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "721269ef-36f8-45bd-b445-4bc8adcebb69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "836a0cfb-3328-41fd-8b2f-2e3503d2aab1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93b24842-5bbf-45da-932d-bcabc5130d33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a418ed40-b4b5-4713-bcb2-0c7bb1b193c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3fc89b7-3c7e-47bd-8625-b8dad06b1692");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5e24750-cf91-45df-8562-f30f54a518d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e653f7c5-47af-4024-9543-97ee7a0c27a4");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Projects",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Development");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "Testing");

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
    }
}

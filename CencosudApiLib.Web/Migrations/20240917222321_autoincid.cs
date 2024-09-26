using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class autoincid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "09f89b73-3993-422b-af47-6fbb1b3bfa2a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "13888c12-96bd-4703-9eea-a816be817de4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "597d003e-a7bd-4c69-b5fd-3e872d5cab4c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6549599a-48a1-47fd-b747-fd7c6dba6d82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "74dfbe66-0aac-49ed-adde-2174ed7840c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7832b27f-7c9e-4618-82a2-7d8db53f3dc3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "862236a9-3e16-4f8b-9e45-8f110ba088ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "89e48c3c-2825-4b73-b089-ccbece2bfb97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a5c24105-39dd-455a-a3b2-c4a7df37f576" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ef9ef357-2149-4aa6-a6d1-4361f45d4888" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f941b0f9-12ea-4e13-a5b6-9ce5ad497623" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f9e75797-3664-4c21-86cd-0f4277d5fe46" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09f89b73-3993-422b-af47-6fbb1b3bfa2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13888c12-96bd-4703-9eea-a816be817de4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "597d003e-a7bd-4c69-b5fd-3e872d5cab4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6549599a-48a1-47fd-b747-fd7c6dba6d82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74dfbe66-0aac-49ed-adde-2174ed7840c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7832b27f-7c9e-4618-82a2-7d8db53f3dc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "862236a9-3e16-4f8b-9e45-8f110ba088ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e48c3c-2825-4b73-b089-ccbece2bfb97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5c24105-39dd-455a-a3b2-c4a7df37f576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef9ef357-2149-4aa6-a6d1-4361f45d4888");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f941b0f9-12ea-4e13-a5b6-9ce5ad497623");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9e75797-3664-4c21-86cd-0f4277d5fe46");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Audits",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "1beb969d-09d8-4f25-915f-a7d7c39490e7", 0, "cb08d03d-94f9-416d-bee7-1ee59dfcd908", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEMtXvJja+uSVA7Tj4ktB03KluLrddRGxLRvNMKtsoUdO5bzvrsh5ItHdhFKpm8VPdA==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 19, 740, DateTimeKind.Local).AddTicks(8352), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "3a732540-6e49-40f8-87bf-da3ac24ed4c9", 0, "4e939773-c05f-4e3c-a32d-a38051c75419", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEF4abPRrsuDjahfPzsVaW6K2vtYHCUg12QAKTZqnu3YdoruTi1eC+M62OH8BziAFmA==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 48, DateTimeKind.Local).AddTicks(4103), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "4b9a198f-435d-4c8b-86df-4018a424ed70", 0, "2631c24e-1560-48d4-97a0-e4a774428eaa", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEIwCdVwnKV2KWW3kCFgELRZp8cmNIgS3ZGsbcCePixVEDWs5h/pb/LB8WLkOsLNIjg==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 19, 923, DateTimeKind.Local).AddTicks(9505), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "638fdf82-ec88-4d27-8cf7-38e3a311de7a", 0, "d2249793-bec5-431f-a89a-a73c2d0224e8", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEB1SHOQdMpOP4+kzW9+CSJq7ghDTjVh6RFYq0lQxfpb4rb9kc6Mw76hKPRnHaSGk3w==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 732, DateTimeKind.Local).AddTicks(904), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "6ce79821-a871-43df-812b-8958a3ac690d", 0, "cd52d399-3f4a-46dd-bb01-bbf2746be4b1", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEF9h8IvFltySYcVSyweHiikFXvqpzoCEMGt/PZyVWUktyu5TWzUnc89gjI6QC7Zysg==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 155, DateTimeKind.Local).AddTicks(4261), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "9039fbea-fa58-4fb4-9d19-72243b084f90", 0, "b1bf5374-ba93-4ee2-9f85-84853cc991e1", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEEmZ9YaL5VjY/yoCezlpVN5VwRJh4kXeT9zLmpiDp8MwGabeCpPz7OKURKeBYcnoVw==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 831, DateTimeKind.Local).AddTicks(8259), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" },
                    { "bd7ba52d-dde6-491e-8182-f1058d53afdb", 0, "933b041b-2028-491a-a81c-d9ca200d7c69", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEBLyHt8kWsQkd73Xab5JoYVmMZggpaAg27vJo7TjOYzVzbAkaPOHTKglj62eNAdoXw==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 270, DateTimeKind.Local).AddTicks(257), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "be9df1e7-cd46-4627-8a2f-379a00e5c7f8", 0, "51896532-12bd-47f8-bbef-2dcf2b4fab02", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEJ+17rjOG7tp4GsPmbKV0osXc+INOANG/Fbz+ODTNCR9wiwFyx9ePaplwLCFtYKpRg==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 437, DateTimeKind.Local).AddTicks(3633), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "d0272b21-ac64-4676-83b2-9ce6dd78c620", 0, "0015697b-e8c0-42dd-b333-b64e90166664", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEKjX04zqE20OT7jaxTWYZ/1TiFWWpDaGhGKsVgBIj4ls0V1B1iqrJRpuT1n+nx5vsw==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 19, 826, DateTimeKind.Local).AddTicks(8804), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "dc536c13-74e8-4c7d-826b-ad1f7299273f", 0, "96d403d7-1e47-467d-a61b-215728a411a4", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEEJ/rVMmZS11emSb2BVarE+XYa1hM9r6VPEH+v25lhOddjZWdqkb/+7NPrnOeoPlHA==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 531, DateTimeKind.Local).AddTicks(1900), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "fd9ea482-4ca3-4c8c-a6ec-74113e46a110", 0, "37a24210-bdcc-4f2d-9e34-f2311750abdf", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEJyL5sh3UirmxDhqbD6VPG7j2vludma2FtbBv2yAdAnvBsgH/PrLHHIjveiAsVXkHw==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 627, DateTimeKind.Local).AddTicks(1096), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "feb61e9a-9d6d-4b90-8ca9-490361b317fc", 0, "b569587c-ddd5-4e10-be74-6b8142696f37", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEP2gxMUvn0UngvXdE4nSWS1yK+5pjGN79ejwnwe9vFxqzLflXThaeim2YGUYDv8qpg==", null, false, "", new DateTime(2024, 9, 17, 19, 23, 20, 354, DateTimeKind.Local).AddTicks(753), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1beb969d-09d8-4f25-915f-a7d7c39490e7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3a732540-6e49-40f8-87bf-da3ac24ed4c9" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4b9a198f-435d-4c8b-86df-4018a424ed70" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "638fdf82-ec88-4d27-8cf7-38e3a311de7a" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6ce79821-a871-43df-812b-8958a3ac690d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9039fbea-fa58-4fb4-9d19-72243b084f90" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "bd7ba52d-dde6-491e-8182-f1058d53afdb" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "be9df1e7-cd46-4627-8a2f-379a00e5c7f8" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d0272b21-ac64-4676-83b2-9ce6dd78c620" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "dc536c13-74e8-4c7d-826b-ad1f7299273f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fd9ea482-4ca3-4c8c-a6ec-74113e46a110" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "feb61e9a-9d6d-4b90-8ca9-490361b317fc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1beb969d-09d8-4f25-915f-a7d7c39490e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3a732540-6e49-40f8-87bf-da3ac24ed4c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4b9a198f-435d-4c8b-86df-4018a424ed70" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "638fdf82-ec88-4d27-8cf7-38e3a311de7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6ce79821-a871-43df-812b-8958a3ac690d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9039fbea-fa58-4fb4-9d19-72243b084f90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "bd7ba52d-dde6-491e-8182-f1058d53afdb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "be9df1e7-cd46-4627-8a2f-379a00e5c7f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d0272b21-ac64-4676-83b2-9ce6dd78c620" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "dc536c13-74e8-4c7d-826b-ad1f7299273f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fd9ea482-4ca3-4c8c-a6ec-74113e46a110" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "feb61e9a-9d6d-4b90-8ca9-490361b317fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1beb969d-09d8-4f25-915f-a7d7c39490e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a732540-6e49-40f8-87bf-da3ac24ed4c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b9a198f-435d-4c8b-86df-4018a424ed70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "638fdf82-ec88-4d27-8cf7-38e3a311de7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ce79821-a871-43df-812b-8958a3ac690d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9039fbea-fa58-4fb4-9d19-72243b084f90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd7ba52d-dde6-491e-8182-f1058d53afdb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be9df1e7-cd46-4627-8a2f-379a00e5c7f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0272b21-ac64-4676-83b2-9ce6dd78c620");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc536c13-74e8-4c7d-826b-ad1f7299273f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9ea482-4ca3-4c8c-a6ec-74113e46a110");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "feb61e9a-9d6d-4b90-8ca9-490361b317fc");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Audits",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "09f89b73-3993-422b-af47-6fbb1b3bfa2a", 0, "548f27ed-7011-44d0-aedd-8e3c1d98a217", "user2@example.com", true, false, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEGqH9Qjai3sewACfN8utVi3l+KETQMLpLnfn4EZhx/hPoGZf0RpNSufEO10V06DT1w==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 263, DateTimeKind.Local).AddTicks(7907), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user2" },
                    { "13888c12-96bd-4703-9eea-a816be817de4", 0, "559fcbcd-8061-4e90-8048-1cd8a39c5ee0", "user10@example.com", true, false, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEPsuMYz5ZazOnSkmB1QPCoAIW3EuRUjAWE6wJ10LUgBJHPBoyrvBBb7X3grQOLHTGw==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 762, DateTimeKind.Local).AddTicks(5689), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user10" },
                    { "597d003e-a7bd-4c69-b5fd-3e872d5cab4c", 0, "81ab355b-b041-4197-a84d-bb834b9bc2ab", "user5@example.com", true, false, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAECQ2LjwVpJ2kfHn78e/kguySgfgfhZ9o6srgFyG1vDHCj5hILRq3fTIeNBv0E+iiyQ==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 461, DateTimeKind.Local).AddTicks(8956), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user5" },
                    { "6549599a-48a1-47fd-b747-fd7c6dba6d82", 0, "b3915954-5ac8-4899-a776-7fa0f08c6b12", "user9@example.com", true, false, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAECPSQ5wOgx9rjEz9yFsOOs77ic6vYkqWfm8M13pzylcbcUJoeuS4hgjGkiTvjVAtOg==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 705, DateTimeKind.Local).AddTicks(9682), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user9" },
                    { "74dfbe66-0aac-49ed-adde-2174ed7840c5", 0, "82409eb6-9637-4483-a014-19eacbd6b696", "user3@example.com", true, false, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEA92Nz+f1uZqm3vERIk3tIuX1n/L4ZYN6tPLWP804DnNnzXB3gS+HfzRsOcc5jSp7Q==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 322, DateTimeKind.Local).AddTicks(1263), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user3" },
                    { "7832b27f-7c9e-4618-82a2-7d8db53f3dc3", 0, "f9d2a506-47cd-48a6-afa9-a076d76cc9aa", "user11@example.com", true, false, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEOplOFW4nuStn+jgw2JkJvgkNcKlUm0kIvywo7wPMZMJgzzd98tpiHBIJI/qPrFWUg==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 818, DateTimeKind.Local).AddTicks(7688), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user11" },
                    { "862236a9-3e16-4f8b-9e45-8f110ba088ff", 0, "2ce3fbfa-c3ce-4131-ae49-091506a0aba8", "user6@example.com", true, false, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEAMgLHJwkf00PniTiQThdFif8MjiSQWq1jpAAE0tQmRNNK26aB7wKTei7OwmnOJoGA==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 524, DateTimeKind.Local).AddTicks(2067), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6" },
                    { "89e48c3c-2825-4b73-b089-ccbece2bfb97", 0, "89e8969f-25f0-4854-9778-0be961a4543a", "user4@example.com", true, false, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEKuNz7ncJT+sZZ4BOipFsAs34nj7treeMD8ncs3aVEEuSkrN8N6v2+N9t21NtAbjTA==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 395, DateTimeKind.Local).AddTicks(1774), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4" },
                    { "a5c24105-39dd-455a-a3b2-c4a7df37f576", 0, "a242784c-c48c-47c9-a2e0-d9cd41deb5cc", "user7@example.com", true, false, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEAwAl3/LCu9oPGh3dgMIiW0CWd48zm4TgR+2VO7q0z8NwhQPavoEo3L77XwYze0VgA==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 585, DateTimeKind.Local).AddTicks(9081), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7" },
                    { "ef9ef357-2149-4aa6-a6d1-4361f45d4888", 0, "1099de59-df43-476e-b0f8-12efbe2867bb", "user8@example.com", true, false, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEH87wcowjTYWNEuG+LF8Su7NtJr0ZQmMk/i9sO6KDKu+YIv4WoNl7Lmpu5vNKij48A==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 649, DateTimeKind.Local).AddTicks(8244), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8" },
                    { "f941b0f9-12ea-4e13-a5b6-9ce5ad497623", 0, "bed36b2d-dc5b-410e-ab8a-5e5bd882adfd", "user1@example.com", true, false, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEOH1d+2MXpEI3uzxocqbA0NcjYPln76Lll1Hn/9bOH2+lKzPVquzP+VoLB5RIunU2Q==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 207, DateTimeKind.Local).AddTicks(7353), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user1" },
                    { "f9e75797-3664-4c21-86cd-0f4277d5fe46", 0, "001083b8-8d25-4de0-8585-7ebbf6ac24b4", "user12@example.com", true, false, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEJm3oiu3YDyv2yZxPxaAVb6IKUIKuW/mjEmbwbC4fIdUEBokhS5FoG/ltjJMZRBssQ==", null, false, "", new DateTime(2024, 9, 17, 19, 15, 30, 879, DateTimeKind.Local).AddTicks(1740), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user12" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "09f89b73-3993-422b-af47-6fbb1b3bfa2a" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "13888c12-96bd-4703-9eea-a816be817de4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "597d003e-a7bd-4c69-b5fd-3e872d5cab4c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6549599a-48a1-47fd-b747-fd7c6dba6d82" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "74dfbe66-0aac-49ed-adde-2174ed7840c5" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7832b27f-7c9e-4618-82a2-7d8db53f3dc3" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "862236a9-3e16-4f8b-9e45-8f110ba088ff" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "89e48c3c-2825-4b73-b089-ccbece2bfb97" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a5c24105-39dd-455a-a3b2-c4a7df37f576" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ef9ef357-2149-4aa6-a6d1-4361f45d4888" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f941b0f9-12ea-4e13-a5b6-9ce5ad497623" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f9e75797-3664-4c21-86cd-0f4277d5fe46" }
                });
        }
    }
}

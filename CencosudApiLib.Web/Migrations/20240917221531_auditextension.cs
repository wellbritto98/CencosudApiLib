using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class auditextension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastLoginAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    TokenExpiredAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TokenCreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Nickname = table.Column<string>(type: "text", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Entity = table.Column<int>(type: "integer", nullable: false),
                    Action = table.Column<string>(type: "text", nullable: false),
                    Changes = table.Column<string>(type: "text", nullable: false),
                    Performed_By = table.Column<string>(type: "text", nullable: false),
                    Performed_At = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => new { x.Id, x.Type, x.Entity });
                    table.ForeignKey(
                        name: "FK_Audits_AspNetUsers_Performed_By",
                        column: x => x.Performed_By,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", null, "Player", "PLAYER" }
                });

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
                table: "Examples",
                columns: new[] { "Id", "IsConfirmed", "IsDeleted", "Name", "Nickname" },
                values: new object[,]
                {
                    { 1, true, false, "Example1", "Example1Nickname" },
                    { 2, true, false, "Example2", "Example2Nickname" },
                    { 3, true, false, "Example3", "Example3Nickname" },
                    { 4, true, false, "Example4", "Example4Nickname" },
                    { 5, true, false, "Example5", "Example5Nickname" },
                    { 6, true, false, "Example6", "Example6Nickname" },
                    { 7, true, false, "Example7", "Example7Nickname" },
                    { 8, true, false, "Example8", "Example8Nickname" },
                    { 9, true, false, "Example9", "Example9Nickname" },
                    { 10, true, false, "Example10", "Example10Nickname" },
                    { 11, true, false, "Example11", "Example11Nickname" },
                    { 12, true, false, "Example12", "Example12Nickname" }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Audits_Performed_By",
                table: "Audits",
                column: "Performed_By");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropTable(
                name: "Examples");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

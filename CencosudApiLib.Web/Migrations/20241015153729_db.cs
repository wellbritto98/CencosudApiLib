using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    BaseUrl = table.Column<string>(type: "text", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apis", x => x.Id);
                });

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
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

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
                name: "ApiInstances",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    ApiId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiInstances", x => new { x.ProjectId, x.ApiId });
                    table.ForeignKey(
                        name: "FK_ApiInstances_Apis_ApiId",
                        column: x => x.ApiId,
                        principalTable: "Apis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApiInstances_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComponentInstance",
                columns: table => new
                {
                    EndpointId = table.Column<int>(type: "integer", nullable: false),
                    ComponentId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentInstance", x => new { x.EndpointId, x.ComponentId });
                    table.ForeignKey(
                        name: "FK_ComponentInstance_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentInstance_Endpoints_EndpointId",
                        column: x => x.EndpointId,
                        principalTable: "Endpoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Components",
                columns: new[] { "Id", "Description", "IsDeleted", "Type" },
                values: new object[,]
                {
                    { 1, "Login procedure", false, 0 },
                    { 2, "Email validation", false, 3 },
                    { 3, "Authentication token generation", false, 5 }
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

            migrationBuilder.InsertData(
                table: "Endpoints",
                columns: new[] { "Id", "ApiId", "Description", "IsDeleted", "Method", "Path" },
                values: new object[,]
                {
                    { 1, 1, "User login endpoint", false, "POST", "/login" },
                    { 2, 1, "User registration endpoint", false, "POST", "/register" },
                    { 3, 2, "Payment charge endpoint", false, "POST", "/charge" },
                    { 4, 3, "Send notification endpoint", false, "POST", "/send" }
                });

            migrationBuilder.InsertData(
                table: "ComponentInstance",
                columns: new[] { "ComponentId", "EndpointId", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, false },
                    { 2, 1, false },
                    { 3, 1, false },
                    { 2, 2, false },
                    { 1, 3, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiInstances_ApiId",
                table: "ApiInstances",
                column: "ApiId");

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
                name: "IX_ComponentInstance_ComponentId",
                table: "ComponentInstance",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Endpoints_ApiId",
                table: "Endpoints",
                column: "ApiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiInstances");

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
                name: "ComponentInstance");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Endpoints");

            migrationBuilder.DropTable(
                name: "Apis");
        }
    }
}

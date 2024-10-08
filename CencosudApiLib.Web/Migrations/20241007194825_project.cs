using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CencosudApiLib.Web.Migrations
{
    /// <inheritdoc />
    public partial class project : Migration
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
                name: "ComponentInstance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EndpointId = table.Column<int>(type: "integer", nullable: false),
                    ComponentId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentInstance", x => x.Id);
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
                name: "Apis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ResponsavelTecnico = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    BaseUrl = table.Column<string>(type: "text", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apis_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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

            migrationBuilder.CreateIndex(
                name: "IX_ApiInstances_ApiId",
                table: "ApiInstances",
                column: "ApiId");

            migrationBuilder.CreateIndex(
                name: "IX_Apis_UserId",
                table: "Apis",
                column: "UserId");

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
                name: "Apis");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

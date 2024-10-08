﻿// <auto-generated />
using System;
using CencosudApiLib.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CencosudApiLib.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241007194825_project")]
    partial class project
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CencosudApiLib.Models.Api", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ResponsavelTecnico")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Apis");
                });

            modelBuilder.Entity("CencosudApiLib.Models.ApiInstance", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    b.Property<int>("ApiId")
                        .HasColumnType("integer")
                        .HasColumnOrder(1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("ProjectId", "ApiId");

                    b.HasIndex("ApiId");

                    b.ToTable("ApiInstances");
                });

            modelBuilder.Entity("CencosudApiLib.Models.Auth.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLoginAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<DateTime>("TokenCreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TokenExpiredAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "aabe168f-5eb2-4389-ad3a-e8d2592a6d8b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2a60a7de-c00f-4752-a00d-d3bf538cbaf7",
                            Email = "user1@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 1",
                            NormalizedEmail = "USER1@EXAMPLE.COM",
                            NormalizedUserName = "USER1",
                            PasswordHash = "AQAAAAIAAYagAAAAEA6Ft4LRiqrKIc7BQLD40EiVlaMRV6siUEk/ITI3otyZJ11WaqiitT4JWTOUO+FMjg==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 23, 995, DateTimeKind.Local).AddTicks(988),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = "5cad271a-3af7-4cf8-9d06-88ac571d83da",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2ee3f431-7afd-4632-a570-fbef0eb1929f",
                            Email = "user2@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 2",
                            NormalizedEmail = "USER2@EXAMPLE.COM",
                            NormalizedUserName = "USER2",
                            PasswordHash = "AQAAAAIAAYagAAAAECOGufy/BkeWGgNw6D60e2uC9+vq/2Py4xpwx7ZR/xA+70kpXebmBaFd4ALvV/qZ9g==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 58, DateTimeKind.Local).AddTicks(5637),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user2"
                        },
                        new
                        {
                            Id = "4f9188c1-89ef-433e-9194-6caf0f204b6d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3cf1a85f-f6dd-42c0-8c06-e13552f9c2ca",
                            Email = "user3@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 3",
                            NormalizedEmail = "USER3@EXAMPLE.COM",
                            NormalizedUserName = "USER3",
                            PasswordHash = "AQAAAAIAAYagAAAAEOgW0zh4dNyUecccNC6jQ5jAVei9x9EiqX5BsTtLig+B1y6pT4fpTyjVgrIgb4i+YA==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 137, DateTimeKind.Local).AddTicks(4150),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user3"
                        },
                        new
                        {
                            Id = "2008491f-d4f7-475b-b3e2-6dea11796fcc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "17fa7fe9-1e4d-412b-9a6a-1d6142417c05",
                            Email = "user4@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 4",
                            NormalizedEmail = "USER4@EXAMPLE.COM",
                            NormalizedUserName = "USER4",
                            PasswordHash = "AQAAAAIAAYagAAAAEENTvATs2vSK3Clg2JHCXYEL7dTnaDmUEeOYUEHmLeCLTtqmu7ie1ilEn4ZZr6dIUA==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 196, DateTimeKind.Local).AddTicks(4441),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user4"
                        },
                        new
                        {
                            Id = "40c66152-5a80-4605-a7f8-c2da1d80ade7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "019f2ccf-c1ac-4fa0-b8b4-28419e0c6607",
                            Email = "user5@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 5",
                            NormalizedEmail = "USER5@EXAMPLE.COM",
                            NormalizedUserName = "USER5",
                            PasswordHash = "AQAAAAIAAYagAAAAEOc2Ke+weJTb1q5RKcZRk8CxotlbwTksbqG2cWpIOnQflyYaadj1D0yxAXikYwTJdA==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 256, DateTimeKind.Local).AddTicks(7995),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user5"
                        },
                        new
                        {
                            Id = "369a1880-a73d-4630-a2b0-a4d3e86b6071",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bee0bcab-4f3c-4beb-a808-2968aa636b63",
                            Email = "user6@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 6",
                            NormalizedEmail = "USER6@EXAMPLE.COM",
                            NormalizedUserName = "USER6",
                            PasswordHash = "AQAAAAIAAYagAAAAEK4j3ZQM+E9RU8jTt605R4+mg/dW3ZCzQKJe9KjJJ8k0nWV/yXNmtCoULzAERAx6UQ==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 324, DateTimeKind.Local).AddTicks(8598),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user6"
                        },
                        new
                        {
                            Id = "a9ee6bf7-2fed-4f73-acda-38edc392a185",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "035beb4c-4c70-4221-bd40-273ff82db281",
                            Email = "user7@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 7",
                            NormalizedEmail = "USER7@EXAMPLE.COM",
                            NormalizedUserName = "USER7",
                            PasswordHash = "AQAAAAIAAYagAAAAEGLVl37rRDf0cYgWOLLlj4mHRUXKKDEZ8bmyP1zCkSez8GFfINX9gL1PIe/KsbK5Jg==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 412, DateTimeKind.Local).AddTicks(4130),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user7"
                        },
                        new
                        {
                            Id = "aada8d36-fcfd-44f1-8661-87cf484f2447",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8f424135-8366-417d-97b7-15d5a1550cd5",
                            Email = "user8@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 8",
                            NormalizedEmail = "USER8@EXAMPLE.COM",
                            NormalizedUserName = "USER8",
                            PasswordHash = "AQAAAAIAAYagAAAAEO3HiEfXaDrB1GnwVZE6esORgmuXh/g9na1eBGfsKvExj6P49tHE+3jpnvl5rL7LRw==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 480, DateTimeKind.Local).AddTicks(6687),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user8"
                        },
                        new
                        {
                            Id = "0a899995-7183-4c05-b989-888f3fc3ba42",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "24388e8b-592c-46a3-9994-c2d0724d87f9",
                            Email = "user9@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 9",
                            NormalizedEmail = "USER9@EXAMPLE.COM",
                            NormalizedUserName = "USER9",
                            PasswordHash = "AQAAAAIAAYagAAAAEESAUJErqaramIxU3ZCsl1vgv0Ytrivfw8OvTcUjhNBh4J45qSPZZBtIA+6M598giA==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 539, DateTimeKind.Local).AddTicks(1159),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user9"
                        },
                        new
                        {
                            Id = "d9ada38b-9546-4a06-8c47-335a52326026",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e3bd0d5-239c-4d99-906b-df9485040a99",
                            Email = "user10@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 10",
                            NormalizedEmail = "USER10@EXAMPLE.COM",
                            NormalizedUserName = "USER10",
                            PasswordHash = "AQAAAAIAAYagAAAAEKZI2ZisVjtX28ZPMeAxEncDLpjMlhIm5UHUCM61ftZtH/FLJuJrG/+7XO8PoAhoBQ==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 596, DateTimeKind.Local).AddTicks(6591),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user10"
                        },
                        new
                        {
                            Id = "55438839-58e1-4482-a020-1ba0032d6948",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed001650-9905-43d8-b4c7-68914af0672b",
                            Email = "user11@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 11",
                            NormalizedEmail = "USER11@EXAMPLE.COM",
                            NormalizedUserName = "USER11",
                            PasswordHash = "AQAAAAIAAYagAAAAEED1MEJz7jHLQcCn+bdpiF1xvJL9igEyN54DN6xzj//S6m48xiJwCOhQEpmCfOcBdw==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 654, DateTimeKind.Local).AddTicks(5677),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user11"
                        },
                        new
                        {
                            Id = "d35c2b7a-de9d-4659-90b6-5167cbd6309c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ebff0e34-f755-4e82-bd7c-9f32f37847d5",
                            Email = "user12@example.com",
                            EmailConfirmed = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            Name = "User 12",
                            NormalizedEmail = "USER12@EXAMPLE.COM",
                            NormalizedUserName = "USER12",
                            PasswordHash = "AQAAAAIAAYagAAAAEDnUbm+ptDps2P3u+QVq7khGm+xCF63D7zLldkmCu5z7OGwuB5xCxzHcb0wxBhyMFg==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisteredAt = new DateTime(2024, 10, 7, 16, 48, 24, 714, DateTimeKind.Local).AddTicks(6488),
                            SecurityStamp = "",
                            TokenCreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TokenExpiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "user12"
                        });
                });

            modelBuilder.Entity("CencosudApiLib.Models.ComponentInstance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ComponentId")
                        .HasColumnType("integer");

                    b.Property<int>("EndpointId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ComponentInstance");
                });

            modelBuilder.Entity("CencosudProjectLib.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                            Name = "Player",
                            NormalizedName = "PLAYER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "aabe168f-5eb2-4389-ad3a-e8d2592a6d8b",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "5cad271a-3af7-4cf8-9d06-88ac571d83da",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "4f9188c1-89ef-433e-9194-6caf0f204b6d",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "2008491f-d4f7-475b-b3e2-6dea11796fcc",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "40c66152-5a80-4605-a7f8-c2da1d80ade7",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "369a1880-a73d-4630-a2b0-a4d3e86b6071",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "a9ee6bf7-2fed-4f73-acda-38edc392a185",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "aada8d36-fcfd-44f1-8661-87cf484f2447",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "0a899995-7183-4c05-b989-888f3fc3ba42",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "d9ada38b-9546-4a06-8c47-335a52326026",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "55438839-58e1-4482-a020-1ba0032d6948",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "d35c2b7a-de9d-4659-90b6-5167cbd6309c",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CencosudApiLib.Models.Api", b =>
                {
                    b.HasOne("CencosudApiLib.Models.Auth.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CencosudApiLib.Models.ApiInstance", b =>
                {
                    b.HasOne("CencosudApiLib.Models.Api", "Api")
                        .WithMany("ApiInstances")
                        .HasForeignKey("ApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CencosudProjectLib.Models.Project", "Project")
                        .WithMany("ApiInstances")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Api");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CencosudApiLib.Models.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CencosudApiLib.Models.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CencosudApiLib.Models.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CencosudApiLib.Models.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CencosudApiLib.Models.Api", b =>
                {
                    b.Navigation("ApiInstances");
                });

            modelBuilder.Entity("CencosudProjectLib.Models.Project", b =>
                {
                    b.Navigation("ApiInstances");
                });
#pragma warning restore 612, 618
        }
    }
}
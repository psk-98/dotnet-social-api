using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_social_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Bio = table.Column<string>(type: "TEXT", nullable: false),
                    Website = table.Column<string>(type: "TEXT", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Follows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FollowerUserId = table.Column<string>(type: "TEXT", nullable: false),
                    FollowerUserProfileId = table.Column<string>(type: "TEXT", nullable: true),
                    FolloweeUserId = table.Column<string>(type: "TEXT", nullable: false),
                    FolloweeUserProfileId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Follows_AspNetUsers_FolloweeUserProfileId",
                        column: x => x.FolloweeUserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Follows_AspNetUsers_FollowerUserProfileId",
                        column: x => x.FollowerUserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MessageThreads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserOneId = table.Column<string>(type: "TEXT", nullable: false),
                    UserTwoId = table.Column<string>(type: "TEXT", nullable: false),
                    UserProfileOneId = table.Column<string>(type: "TEXT", nullable: true),
                    UserProfileTwoId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageThreads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageThreads_AspNetUsers_UserProfileOneId",
                        column: x => x.UserProfileOneId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MessageThreads_AspNetUsers_UserProfileTwoId",
                        column: x => x.UserProfileTwoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserProfileId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    IsSeen = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SenderUserProfileId = table.Column<string>(type: "TEXT", nullable: false),
                    MessageThreadId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderUserProfileId",
                        column: x => x.SenderUserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_MessageThreads_MessageThreadId",
                        column: x => x.MessageThreadId,
                        principalTable: "MessageThreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserProfileId = table.Column<string>(type: "TEXT", nullable: false),
                    PostId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserProfileId = table.Column<string>(type: "TEXT", nullable: false),
                    PostId = table.Column<int>(type: "INTEGER", nullable: true),
                    CommentId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Likes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSeen = table.Column<bool>(type: "INTEGER", nullable: false),
                    ToUserProfileId = table.Column<string>(type: "TEXT", nullable: false),
                    FromUserProfileId = table.Column<string>(type: "TEXT", nullable: false),
                    PostId = table.Column<int>(type: "INTEGER", nullable: true),
                    CommentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_FromUserProfileId",
                        column: x => x.FromUserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_ToUserProfileId",
                        column: x => x.ToUserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29f2739f-4b58-46c8-b26e-e0fd6495e7b9", null, "Admin", "ADMIN" },
                    { "633be567-c97f-4e5b-a303-ec0ab3d312a1", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DateJoined", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Website" },
                values: new object[,]
                {
                    { "0f6a348a-760e-4f67-8a72-fb1397b43f23", 0, "Marketing Specialist", "679ed601-b492-49d3-8436-337742609fa3", new DateTime(2024, 8, 27, 18, 10, 2, 372, DateTimeKind.Local).AddTicks(7321), "marketer@localhost", false, false, null, null, "MARKETER", "AQAAAAIAAYagAAAAEA1hJ0Z6Tc30/gZn2rOOI1/sFVFcbFlvyf8DOYfKZpfgMT1VgbziMlBsyVMDuc477Q==", null, false, "aa75599c-ddd6-4df6-85e5-467c433f1a8c", false, "Marketer", "http://market.local" },
                    { "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", 0, "Creative Designer", "9a211798-ba81-4fb3-8712-da1988087866", new DateTime(2024, 8, 27, 18, 10, 2, 303, DateTimeKind.Local).AddTicks(6145), "designguru@localhost", false, false, null, null, "DESIGNGURU", "AQAAAAIAAYagAAAAEHzLdVx3iJ2gKsyHJ+iWOeorh2TMEm45IbEo6G9v3Ss1X96/cqXtZtq8WI/w+cow5g==", null, false, "7273afea-78e9-4f6e-a2f9-3b9e1144b767", false, "DesignGuru", "http://design.local" },
                    { "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", 0, "Customer Support Tech", "939cdd4d-81a3-47ad-b08c-4e2db6f4fc05", new DateTime(2024, 8, 27, 18, 10, 2, 441, DateTimeKind.Local).AddTicks(2072), "supporttech@localhost", false, false, null, null, "SUPPORTTECH", "AQAAAAIAAYagAAAAELY3wfx97ENdpGPJhLoYX1a0Cvh20DxZ7MAyoNlJtpJRW0ZeUAc31Gw9yVSOrusgIA==", null, false, "b10dffcf-ab38-4ffc-9532-234a50db4fbe", false, "SupportTech", "http://support.local" },
                    { "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", 0, "Software Developer", "20ad7375-31c5-4299-a486-2a7a48a6c362", new DateTime(2024, 8, 27, 18, 10, 2, 234, DateTimeKind.Local).AddTicks(3863), "devuser@localhost", false, false, null, null, "DEVUSER", "AQAAAAIAAYagAAAAEGdVCqhYiQPNE87qNgRZScsmgSXj9XAUn3U/DjflZloyiwUulkOeeg0C3EsvuO3L1g==", null, false, "bb9c20c5-45d1-4648-b968-3e48e3ebd66d", false, "DevUser", "http://devsite.local" },
                    { "ed677356-50e3-4640-8077-99db7f391a5b", 0, "System Administrator", "89e7f2cb-0022-422e-b06f-c33e83e9bb9c", new DateTime(2024, 8, 27, 18, 10, 2, 167, DateTimeKind.Local).AddTicks(9743), "admin@localhost", false, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEA56tQlnOn3oaWBoclS0jIY0TeoFINLh+Rc/FDFGgl01mZSe0bD3oilA6C3ABrvIuw==", null, false, "f15c2f6f-0364-42c2-b3df-b397e89e9a19", false, "Admin", "http://localhost" }
                });

            migrationBuilder.InsertData(
                table: "Follows",
                columns: new[] { "Id", "FolloweeUserId", "FolloweeUserProfileId", "FollowerUserId", "FollowerUserProfileId" },
                values: new object[,]
                {
                    { 1, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", null, "ed677356-50e3-4640-8077-99db7f391a5b", null },
                    { 2, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", null, "ed677356-50e3-4640-8077-99db7f391a5b", null },
                    { 3, "0f6a348a-760e-4f67-8a72-fb1397b43f23", null, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", null },
                    { 4, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", null, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", null },
                    { 5, "ed677356-50e3-4640-8077-99db7f391a5b", null, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", null },
                    { 6, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", null, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", null },
                    { 7, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", null, "0f6a348a-760e-4f67-8a72-fb1397b43f23", null },
                    { 8, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", null, "0f6a348a-760e-4f67-8a72-fb1397b43f23", null },
                    { 9, "ed677356-50e3-4640-8077-99db7f391a5b", null, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", null },
                    { 10, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", null, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedOn", "UserProfileId" },
                values: new object[,]
                {
                    { 1, "Welcome to the system! Excited to have you here.", new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 2, "System maintenance scheduled for tonight.", new DateTime(2024, 8, 27, 10, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 3, "New feature release notes available in the documentation.", new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 4, "Reminder: Update your profile settings.", new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 5, "Check out the latest system reports.", new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 6, "Just pushed a new update to the repository.", new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 7, "Working on improving the API performance.", new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 8, "Dev meetup scheduled for next week.", new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 9, "New blog post on best coding practices.", new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 10, "Exploring new tools for developers.", new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 11, "Check out the latest design trends.", new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 12, "Redesigned the homepage for a client.", new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 13, "Design tips for creating effective UI.", new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 14, "How to use color theory in design.", new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 15, "Design project management tips.", new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 16, "New marketing strategy launched.", new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 17, "Top 5 tips for effective social media marketing.", new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 18, "Exploring new digital marketing tools.", new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 19, "Analyzing the latest marketing trends.", new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 20, "Effective strategies for increasing engagement.", new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 21, "Support hours extended this week.", new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 22, "New troubleshooting guide available.", new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 23, "How to resolve common support issues.", new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 24, "Tips for better customer support.", new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 25, "New features in the support portal.", new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Body", "CreatedOn", "PostId", "UserProfileId" },
                values: new object[,]
                {
                    { 1, "Great post! Really enjoyed the insights.", new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 1, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 2, "Thanks for sharing this information.", new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 2, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 3, "This was very helpful. Looking forward to more updates!", new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 3, "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 4, "I disagree with some of the points mentioned.", new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 4, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 5, "Can you provide more details on this topic?", new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 5, "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 6, "Amazing content! Keep up the great work.", new DateTime(2024, 8, 21, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 6, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 7, "Very informative, but could use some examples.", new DateTime(2024, 8, 20, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 7, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 8, "Nice article. I learned something new today!", new DateTime(2024, 8, 19, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 8, "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 9, "Good read, but could be more concise.", new DateTime(2024, 8, 18, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 9, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 10, "Interesting perspective, thanks for sharing!", new DateTime(2024, 8, 17, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 10, "ed677356-50e3-4640-8077-99db7f391a5b" }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "CommentId", "CreatedOn", "PostId", "UserProfileId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 1, "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 2, null, new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 2, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 3, null, new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 3, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 4, null, new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 4, "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 5, null, new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), 5, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CommentId", "CreatedOn", "FromUserProfileId", "IsSeen", "PostId", "ToUserProfileId", "Type" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", false, 1, "ed677356-50e3-4640-8077-99db7f391a5b", 3 },
                    { 2, null, new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", false, 2, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", 3 },
                    { 3, null, new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "0f6a348a-760e-4f67-8a72-fb1397b43f23", false, 3, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", 3 },
                    { 4, null, new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", false, 4, "0f6a348a-760e-4f67-8a72-fb1397b43f23", 3 },
                    { 5, null, new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "ed677356-50e3-4640-8077-99db7f391a5b", false, 5, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", 3 }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "CommentId", "CreatedOn", "PostId", "UserProfileId" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), null, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 7, 2, new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), null, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 8, 3, new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), null, "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 9, 4, new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), null, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 10, 5, new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), null, "ed677356-50e3-4640-8077-99db7f391a5b" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CommentId", "CreatedOn", "FromUserProfileId", "IsSeen", "PostId", "ToUserProfileId", "Type" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", false, null, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", 3 },
                    { 7, 2, new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "0f6a348a-760e-4f67-8a72-fb1397b43f23", false, null, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", 3 },
                    { 8, 3, new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", false, null, "0f6a348a-760e-4f67-8a72-fb1397b43f23", 3 },
                    { 9, 4, new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "ed677356-50e3-4640-8077-99db7f391a5b", false, null, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", 3 },
                    { 10, 5, new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", false, null, "ed677356-50e3-4640-8077-99db7f391a5b", 3 }
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
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserProfileId",
                table: "Comments",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FolloweeUserProfileId",
                table: "Follows",
                column: "FolloweeUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FollowerUserProfileId",
                table: "Follows",
                column: "FollowerUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CommentId",
                table: "Likes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostId",
                table: "Likes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserProfileId",
                table: "Likes",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MessageThreadId",
                table: "Messages",
                column: "MessageThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderUserProfileId",
                table: "Messages",
                column: "SenderUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageThreads_UserProfileOneId",
                table: "MessageThreads",
                column: "UserProfileOneId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageThreads_UserProfileTwoId",
                table: "MessageThreads",
                column: "UserProfileTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CommentId",
                table: "Notifications",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_FromUserProfileId",
                table: "Notifications",
                column: "FromUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PostId",
                table: "Notifications",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ToUserProfileId",
                table: "Notifications",
                column: "ToUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserProfileId",
                table: "Posts",
                column: "UserProfileId");
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
                name: "Follows");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "MessageThreads");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

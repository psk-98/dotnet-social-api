using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_social_api.Migrations
{
    /// <inheritdoc />
    public partial class finalseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d50e43e-1012-46c6-a587-6593bb7aa450");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb10387d-4b67-40ab-88dd-a72e98011353");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Notifications",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Notifications",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03a67502-5fd3-4c0b-b2dd-7507e50f1540", null, "Admin", "ADMIN" },
                    { "9619dbce-e238-4c84-a4e3-3f6a1502073f", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7ab1d65-bc69-4f07-91d1-d16998312bfe", new DateTime(2024, 8, 26, 12, 39, 15, 353, DateTimeKind.Local).AddTicks(9780), "AQAAAAIAAYagAAAAEExcMta2muW7b/ZyNhYqmo7iNlvGuTx2BnugJEDsI8eBNchDG9Uig3YsUOviGeNNPw==", "b9af436f-24cb-41e0-b949-bbef6e1ea563" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd1951a-5501-4eae-86e7-5a363e182eb3", new DateTime(2024, 8, 26, 12, 39, 15, 286, DateTimeKind.Local).AddTicks(3370), "AQAAAAIAAYagAAAAEHnpzvRvC0RmQOtO2KIVTPKJD9i+PMnEyiSg4ZS3wLYMje0i10V7RyODx7X9nndyuw==", "04fbff62-4743-4b15-b531-5f5482eb6846" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91c0e83d-c884-4d10-b66a-3133e13c6a0e", new DateTime(2024, 8, 26, 12, 39, 15, 421, DateTimeKind.Local).AddTicks(5460), "AQAAAAIAAYagAAAAEM5yOokixgf1RK4ztHViVd6CAnfiDFaRPs3P3yj+W6Eydm8EokFUAuSVPuw0XJc+6A==", "8354110c-8f2e-4fbc-82ad-4c99debba112" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce29618a-5400-4208-853a-a6714178a9e8", new DateTime(2024, 8, 26, 12, 39, 15, 218, DateTimeKind.Local).AddTicks(6710), "AQAAAAIAAYagAAAAECoEyNz2Q3/ajEySddmN+KkJVx/i8TALfZ6JJbNJSpCqWM0m06RSySDNBC3SxBD/9w==", "fda591d8-4964-4426-ab57-7ef7e5228182" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed677356-50e3-4640-8077-99db7f391a5b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a36d751-fd1c-48dc-b591-42bba3d7dd05", new DateTime(2024, 8, 26, 12, 39, 15, 150, DateTimeKind.Local).AddTicks(8160), "AQAAAAIAAYagAAAAEH7bCKl62vNWoAw65BP0/A3ZG0B+rZLso+K/v3oveN58o6tCgxdOy+uULIdCm3SdRw==", "749dedc7-9613-4c97-b377-cfac40ce6508" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 18, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 17, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CommentId", "CreatedOn", "FromUserProfileId", "IsSeen", "PostId", "ToUserProfileId", "Type" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", false, 1, "ed677356-50e3-4640-8077-99db7f391a5b", 3 },
                    { 2, null, new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", false, 2, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", 3 },
                    { 3, null, new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "0f6a348a-760e-4f67-8a72-fb1397b43f23", false, 3, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", 3 },
                    { 4, null, new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", false, 4, "0f6a348a-760e-4f67-8a72-fb1397b43f23", 3 },
                    { 5, null, new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "ed677356-50e3-4640-8077-99db7f391a5b", false, 5, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", 3 },
                    { 6, 1, new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", false, null, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", 3 },
                    { 7, 2, new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "0f6a348a-760e-4f67-8a72-fb1397b43f23", false, null, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", 3 },
                    { 8, 3, new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", false, null, "0f6a348a-760e-4f67-8a72-fb1397b43f23", 3 },
                    { 9, 4, new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "ed677356-50e3-4640-8077-99db7f391a5b", false, null, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", 3 },
                    { 10, 5, new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", false, null, "ed677356-50e3-4640-8077-99db7f391a5b", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 4, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 39, 15, 147, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CommentId",
                table: "Notifications",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PostId",
                table: "Notifications",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Comments_CommentId",
                table: "Notifications",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Posts_PostId",
                table: "Notifications",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Comments_CommentId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Posts_PostId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_CommentId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_PostId",
                table: "Notifications");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03a67502-5fd3-4c0b-b2dd-7507e50f1540");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9619dbce-e238-4c84-a4e3-3f6a1502073f");

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Notifications");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d50e43e-1012-46c6-a587-6593bb7aa450", null, "Admin", "ADMIN" },
                    { "bb10387d-4b67-40ab-88dd-a72e98011353", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de688614-3089-4c23-9cf6-381025b16348", new DateTime(2024, 8, 26, 12, 22, 54, 345, DateTimeKind.Local).AddTicks(6850), "AQAAAAIAAYagAAAAEG59js6gntlZsgGuno/LFxdBrW75CPRfkXonMj1L2qzf0BEEOnsnVHxBeaYI512t0w==", "b691d229-5a82-43e7-ba80-11b3dc4c0cfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12873df2-fd34-4db5-a13c-d173c7835a94", new DateTime(2024, 8, 26, 12, 22, 54, 278, DateTimeKind.Local).AddTicks(1100), "AQAAAAIAAYagAAAAEFaU6dRp/NERIl60rMLQG1oNX9DbfvbRVt6tdCGyqNAGL0qzf+DGs7NhRrwKYL3ZgA==", "29c88977-344f-4db6-ab32-d02e6fbd01de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "876b9785-a84a-4f98-a1f9-7ae60d24a01d", new DateTime(2024, 8, 26, 12, 22, 54, 413, DateTimeKind.Local).AddTicks(2650), "AQAAAAIAAYagAAAAEGxtvKPO47TBToRsaqQZWjNttfZoHEzaq0AtHxrb3+td1zYQLimM702eo78EXDi/lQ==", "bb0ef431-1727-4349-acec-a3b59de94248" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a572f87-15cd-4b7b-aa10-2651be8ce6ab", new DateTime(2024, 8, 26, 12, 22, 54, 210, DateTimeKind.Local).AddTicks(5620), "AQAAAAIAAYagAAAAEI+CoQ4NoHiCitfSmzHmZ4KfW3uMD7V+C1+tyCHX6u0ZBY81sH+Eb3MGXiBoXUdDHw==", "8d48e441-7a7f-4f9b-b747-ad0221c05acf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed677356-50e3-4640-8077-99db7f391a5b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a75cd59-5f41-461c-b4ea-f8ec78327687", new DateTime(2024, 8, 26, 12, 22, 54, 142, DateTimeKind.Local).AddTicks(8810), "AQAAAAIAAYagAAAAEDO/JrW4tyojy8Fu4PvAofbJ5eGSgDx4YrTeFgKmRUebZ7m8qMmVdxfx1udJeH64oQ==", "4fb2b885-84c1-4871-95e3-50c7cc5c15e8" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 18, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 17, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 4, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220));
        }
    }
}

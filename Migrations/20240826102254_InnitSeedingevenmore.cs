using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_social_api.Migrations
{
    /// <inheritdoc />
    public partial class InnitSeedingevenmore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "271ae558-d7dd-447a-a7cf-a1ed8a68e92d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb57ceb2-053d-479e-82e2-7d0e2b4b5289");

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
                table: "Likes",
                columns: new[] { "Id", "CommentId", "CreatedOn", "PostId", "UserProfileId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), 1, "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 2, null, new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), 2, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 3, null, new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), 3, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 4, null, new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), 4, "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 5, null, new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), 5, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 6, 1, new DateTime(2024, 8, 25, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), null, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 7, 2, new DateTime(2024, 8, 24, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), null, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 8, 3, new DateTime(2024, 8, 23, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), null, "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 9, 4, new DateTime(2024, 8, 22, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), null, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 10, 5, new DateTime(2024, 8, 21, 10, 22, 54, 139, DateTimeKind.Utc).AddTicks(4220), null, "ed677356-50e3-4640-8077-99db7f391a5b" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d50e43e-1012-46c6-a587-6593bb7aa450");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb10387d-4b67-40ab-88dd-a72e98011353");

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "271ae558-d7dd-447a-a7cf-a1ed8a68e92d", null, "Admin", "ADMIN" },
                    { "eb57ceb2-053d-479e-82e2-7d0e2b4b5289", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "789fd5e9-4419-4dc4-ac5e-c49e399ab4fe", new DateTime(2024, 8, 26, 11, 32, 30, 145, DateTimeKind.Local).AddTicks(830), "AQAAAAIAAYagAAAAEHKs+4E8DJ/yWq6hIJvx9EnTVqqAU5UwKpqZ1CO90FcfuSGbn3zYHwEknef4atE64Q==", "a7d4579e-956f-4a49-8fe8-ab485fb62ae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4536a4e-e03a-4d1a-b26e-97fb9fe5c904", new DateTime(2024, 8, 26, 11, 32, 30, 77, DateTimeKind.Local).AddTicks(5460), "AQAAAAIAAYagAAAAEGxPP+vXnBkUdxxcyYarRI6PG5IQaegBWNM7mp14df16fCjHVLnM87kkbOs9pvsk8Q==", "66a76831-a582-44bc-86a8-0e23e312e99f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42c9b5a1-351b-40c5-9ec0-5a215d30bd5c", new DateTime(2024, 8, 26, 11, 32, 30, 212, DateTimeKind.Local).AddTicks(7220), "AQAAAAIAAYagAAAAEFpQm+Y9wZ1Tdcz58PxJFWBPEWTWFjs4pPp1JPLSADPXlLXfUkeZ7JEx2Osigq4/9g==", "35c3ba9c-be4f-4f0e-bc78-b49d879660ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30083a90-f872-4560-8355-9f5e67fb0693", new DateTime(2024, 8, 26, 11, 32, 30, 9, DateTimeKind.Local).AddTicks(9480), "AQAAAAIAAYagAAAAEPlbggt4yZKueYIx15kVlqG66MAALKOnqm0MuR9yUgXetqPVitGRmnpwTuvSW9Orqw==", "902aa31d-522e-4d0e-8b7d-491098f0db88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed677356-50e3-4640-8077-99db7f391a5b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ec6b36b-7599-4ffd-8c93-b71262bc9f1f", new DateTime(2024, 8, 26, 11, 32, 29, 939, DateTimeKind.Local).AddTicks(2790), "AQAAAAIAAYagAAAAEGuwrx+313m32m2UsXiSPuZ857O7xllCgk/beLp2SLj0ZPNPL9FHNAeMl9APC4Cq0A==", "0e8b8c42-eadc-43fe-978f-350f566e9f15" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 18, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 17, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 3, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_social_api.Migrations
{
    /// <inheritdoc />
    public partial class AddingProfilePicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29f2739f-4b58-46c8-b26e-e0fd6495e7b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "633be567-c97f-4e5b-a303-ec0ab3d312a1");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4853653d-02a7-4b49-ac88-ca57983158fe", null, "User", "USER" },
                    { "89d5b625-1d25-4f2c-8746-1bc2e6a5ac3d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "fcec1381-fb90-4acd-8022-64c7ac59f084", new DateTime(2024, 9, 17, 18, 24, 37, 47, DateTimeKind.Local).AddTicks(1502), "AQAAAAIAAYagAAAAECv8hx7Nsjcj8ZvrOqAkBpzzJH+waQtFUaCiuHSgXmS70Hd4g6cJ60XaXwO5Ei424g==", "", "dada83bd-41db-43ed-b4ee-03fc2b7d4fe0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "1e1219fd-689f-4693-85a3-571405f6b5cc", new DateTime(2024, 9, 17, 18, 24, 36, 971, DateTimeKind.Local).AddTicks(8021), "AQAAAAIAAYagAAAAEB2kIsWg4RwLE0yuNut7Mp/yO4qfschkUqh0tgILXIhyQO8y5mVCfhbdgJtiILU/WQ==", "", "dff6e51a-fea3-419d-ae87-8c4df169c791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "3365b895-f519-4df7-8de6-76dea5b88b8d", new DateTime(2024, 9, 17, 18, 24, 37, 122, DateTimeKind.Local).AddTicks(3177), "AQAAAAIAAYagAAAAEJfRxyZjrjF30tvcatQ58VjPc1TJowNSUJMU4cdUqeH1dxGJBMFBVzQhutXx3ryUNw==", "", "59f9648c-d97a-4087-b860-3d9db53ee836" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "1572a197-cf6b-41bf-a345-a826dfcbbc1b", new DateTime(2024, 9, 17, 18, 24, 36, 892, DateTimeKind.Local).AddTicks(7613), "AQAAAAIAAYagAAAAEDu2kHmmVUybqC6gyNVBZmN0/p/WlvTEIy57QlX3n9WeGWREJFzLwKZ99oSkMtS1hg==", "", "b8ff8f84-960d-427b-9fde-a6f8bc02d75c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed677356-50e3-4640-8077-99db7f391a5b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "c84e595e-c5db-4197-899b-a13f773f48b3", new DateTime(2024, 9, 17, 18, 24, 36, 822, DateTimeKind.Local).AddTicks(6875), "AQAAAAIAAYagAAAAEAN9gYaG4RHejqXkUifdbB9IeZ/942STxwjR72VEh+hDX6Z+SWNcZj1jsyZpiQcZbw==", "", "2e3cd608-3eec-42e1-834d-f3b955a388ea" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 11, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 10, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 9, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 8, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 7, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 17, 10, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 16, 24, 36, 818, DateTimeKind.Utc).AddTicks(3767));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4853653d-02a7-4b49-ac88-ca57983158fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89d5b625-1d25-4f2c-8746-1bc2e6a5ac3d");

            migrationBuilder.DropColumn(
                name: "ProfilePictureUrl",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29f2739f-4b58-46c8-b26e-e0fd6495e7b9", null, "Admin", "ADMIN" },
                    { "633be567-c97f-4e5b-a303-ec0ab3d312a1", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "679ed601-b492-49d3-8436-337742609fa3", new DateTime(2024, 8, 27, 18, 10, 2, 372, DateTimeKind.Local).AddTicks(7321), "AQAAAAIAAYagAAAAEA1hJ0Z6Tc30/gZn2rOOI1/sFVFcbFlvyf8DOYfKZpfgMT1VgbziMlBsyVMDuc477Q==", "aa75599c-ddd6-4df6-85e5-467c433f1a8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a211798-ba81-4fb3-8712-da1988087866", new DateTime(2024, 8, 27, 18, 10, 2, 303, DateTimeKind.Local).AddTicks(6145), "AQAAAAIAAYagAAAAEHzLdVx3iJ2gKsyHJ+iWOeorh2TMEm45IbEo6G9v3Ss1X96/cqXtZtq8WI/w+cow5g==", "7273afea-78e9-4f6e-a2f9-3b9e1144b767" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "939cdd4d-81a3-47ad-b08c-4e2db6f4fc05", new DateTime(2024, 8, 27, 18, 10, 2, 441, DateTimeKind.Local).AddTicks(2072), "AQAAAAIAAYagAAAAELY3wfx97ENdpGPJhLoYX1a0Cvh20DxZ7MAyoNlJtpJRW0ZeUAc31Gw9yVSOrusgIA==", "b10dffcf-ab38-4ffc-9532-234a50db4fbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20ad7375-31c5-4299-a486-2a7a48a6c362", new DateTime(2024, 8, 27, 18, 10, 2, 234, DateTimeKind.Local).AddTicks(3863), "AQAAAAIAAYagAAAAEGdVCqhYiQPNE87qNgRZScsmgSXj9XAUn3U/DjflZloyiwUulkOeeg0C3EsvuO3L1g==", "bb9c20c5-45d1-4648-b968-3e48e3ebd66d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed677356-50e3-4640-8077-99db7f391a5b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89e7f2cb-0022-422e-b06f-c33e83e9bb9c", new DateTime(2024, 8, 27, 18, 10, 2, 167, DateTimeKind.Local).AddTicks(9743), "AQAAAAIAAYagAAAAEA56tQlnOn3oaWBoclS0jIY0TeoFINLh+Rc/FDFGgl01mZSe0bD3oilA6C3ABrvIuw==", "f15c2f6f-0364-42c2-b3df-b397e89e9a19" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 18, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 17, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 10, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 25, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 24, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 23, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 22, 16, 10, 2, 163, DateTimeKind.Utc).AddTicks(9214));
        }
    }
}

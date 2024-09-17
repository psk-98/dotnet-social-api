using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_social_api.Migrations
{
    /// <inheritdoc />
    public partial class AddingProfilePictures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4853653d-02a7-4b49-ac88-ca57983158fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89d5b625-1d25-4f2c-8746-1bc2e6a5ac3d");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                newName: "ProfilePictureName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d04617a-0ef3-45c6-9d41-bf6312f96412", null, "Admin", "ADMIN" },
                    { "688246e6-6d2c-4ae7-864c-7f150b933584", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ab5e549-1f7d-42c8-abeb-ece30107aaf4", new DateTime(2024, 9, 17, 20, 14, 9, 615, DateTimeKind.Local).AddTicks(6153), "AQAAAAIAAYagAAAAEJvIXhMQ/3KBox2Z5VkhdclvHYFO/HnlcDhudHjMsrEcRoLK/ddizwYcE3nqneBd0Q==", "c0b62531-ae7e-4d4c-98ca-764a08823801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "940f6ad9-52f7-476c-8a97-864a5106329e", new DateTime(2024, 9, 17, 20, 14, 9, 540, DateTimeKind.Local).AddTicks(438), "AQAAAAIAAYagAAAAEKKqkBd5Sp6y5uRFe7N/vrfAfhFfJ130yRwtJLRuStwUOahf3VRGaoHa0wiaXKpp3w==", "2b6a83c5-5a0b-4e01-8f36-f4fc8dcdca63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b081550f-f23b-4141-b48a-7283a8f1408b", new DateTime(2024, 9, 17, 20, 14, 9, 691, DateTimeKind.Local).AddTicks(3011), "AQAAAAIAAYagAAAAENQqjzfjj3D2IR8gXtCP+uj5bTN/FvqyRcxLznrXFwCatUXNAXXqSQPDjriGD+ONAA==", "8f0e59ba-e5c6-4ba8-8349-13c79509768c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1bae0eb-7c99-4114-a750-78d76c23e20b", new DateTime(2024, 9, 17, 20, 14, 9, 463, DateTimeKind.Local).AddTicks(9094), "AQAAAAIAAYagAAAAEDilCueNL+odzBE07z7c9/6NVTVR8g3s5wGx7wxG8pvzQpXIzsmvT5YSmTasDXDFMw==", "f4078e26-3172-440d-9733-e156c68916e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed677356-50e3-4640-8077-99db7f391a5b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3428cec5-c49a-4b16-8c80-0adba3876584", new DateTime(2024, 9, 17, 20, 14, 9, 388, DateTimeKind.Local).AddTicks(4850), "AQAAAAIAAYagAAAAEJEJ9BVBTSmQvkNfQlj0rJzdtkjEE0vMoLGXr8KBJeuwSGYHn+Y8Bczn1NXp0fSO1Q==", "dcf04424-698c-4ff6-afcf-8c22b36cf2b8" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 11, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 10, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 9, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 8, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 7, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 17, 12, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 16, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 15, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 14, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 13, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 12, 18, 14, 9, 383, DateTimeKind.Utc).AddTicks(4582));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d04617a-0ef3-45c6-9d41-bf6312f96412");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "688246e6-6d2c-4ae7-864c-7f150b933584");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureName",
                table: "AspNetUsers",
                newName: "ProfilePictureUrl");

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
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcec1381-fb90-4acd-8022-64c7ac59f084", new DateTime(2024, 9, 17, 18, 24, 37, 47, DateTimeKind.Local).AddTicks(1502), "AQAAAAIAAYagAAAAECv8hx7Nsjcj8ZvrOqAkBpzzJH+waQtFUaCiuHSgXmS70Hd4g6cJ60XaXwO5Ei424g==", "dada83bd-41db-43ed-b4ee-03fc2b7d4fe0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e1219fd-689f-4693-85a3-571405f6b5cc", new DateTime(2024, 9, 17, 18, 24, 36, 971, DateTimeKind.Local).AddTicks(8021), "AQAAAAIAAYagAAAAEB2kIsWg4RwLE0yuNut7Mp/yO4qfschkUqh0tgILXIhyQO8y5mVCfhbdgJtiILU/WQ==", "dff6e51a-fea3-419d-ae87-8c4df169c791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3365b895-f519-4df7-8de6-76dea5b88b8d", new DateTime(2024, 9, 17, 18, 24, 37, 122, DateTimeKind.Local).AddTicks(3177), "AQAAAAIAAYagAAAAEJfRxyZjrjF30tvcatQ58VjPc1TJowNSUJMU4cdUqeH1dxGJBMFBVzQhutXx3ryUNw==", "59f9648c-d97a-4087-b860-3d9db53ee836" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1572a197-cf6b-41bf-a345-a826dfcbbc1b", new DateTime(2024, 9, 17, 18, 24, 36, 892, DateTimeKind.Local).AddTicks(7613), "AQAAAAIAAYagAAAAEDu2kHmmVUybqC6gyNVBZmN0/p/WlvTEIy57QlX3n9WeGWREJFzLwKZ99oSkMtS1hg==", "b8ff8f84-960d-427b-9fde-a6f8bc02d75c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed677356-50e3-4640-8077-99db7f391a5b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c84e595e-c5db-4197-899b-a13f773f48b3", new DateTime(2024, 9, 17, 18, 24, 36, 822, DateTimeKind.Local).AddTicks(6875), "AQAAAAIAAYagAAAAEAN9gYaG4RHejqXkUifdbB9IeZ/942STxwjR72VEh+hDX6Z+SWNcZj1jsyZpiQcZbw==", "2e3cd608-3eec-42e1-834d-f3b955a388ea" });

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_social_api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFollowToUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a15d76f-42fd-4767-83c8-1beb8d656c2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be9f01a9-2fed-4ac8-94ca-93d350b07e1d");

            migrationBuilder.RenameColumn(
                name: "FollowerUserId",
                table: "Follows",
                newName: "FollowerUsername");

            migrationBuilder.RenameColumn(
                name: "FolloweeUserId",
                table: "Follows",
                newName: "FolloweeUsername");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ca3d3d13-74ae-45a0-9c5b-0e498e91d332", null, "User", "USER" },
                    { "e8aa08c2-0e5a-46aa-9bd2-af595c1abd95", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca3d3d13-74ae-45a0-9c5b-0e498e91d332");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8aa08c2-0e5a-46aa-9bd2-af595c1abd95");

            migrationBuilder.RenameColumn(
                name: "FollowerUsername",
                table: "Follows",
                newName: "FollowerUserId");

            migrationBuilder.RenameColumn(
                name: "FolloweeUsername",
                table: "Follows",
                newName: "FolloweeUserId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a15d76f-42fd-4767-83c8-1beb8d656c2e", null, "User", "USER" },
                    { "be9f01a9-2fed-4ac8-94ca-93d350b07e1d", null, "Admin", "ADMIN" }
                });
        }
    }
}

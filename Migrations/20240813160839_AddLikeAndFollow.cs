using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_social_api.Migrations
{
    /// <inheritdoc />
    public partial class AddLikeAndFollow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d80c15-20ea-471e-9dfe-bc174cb3574e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "605473f5-acca-4b9c-a1d4-f1f62a3cde66");

            migrationBuilder.RenameColumn(
                name: "HasBeenSeen",
                table: "Notifications",
                newName: "IsSeen");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adf0ef9f-5990-454c-99fc-bddc1f5fa680", null, "Admin", "ADMIN" },
                    { "d57c7fce-c7c4-4e3d-a2c8-f0b6897468f8", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FolloweeUserProfileId",
                table: "Follows",
                column: "FolloweeUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FollowerUserProfileId",
                table: "Follows",
                column: "FollowerUserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Follows");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adf0ef9f-5990-454c-99fc-bddc1f5fa680");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d57c7fce-c7c4-4e3d-a2c8-f0b6897468f8");

            migrationBuilder.RenameColumn(
                name: "IsSeen",
                table: "Notifications",
                newName: "HasBeenSeen");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11d80c15-20ea-471e-9dfe-bc174cb3574e", null, "Admin", "ADMIN" },
                    { "605473f5-acca-4b9c-a1d4-f1f62a3cde66", null, "User", "USER" }
                });
        }
    }
}

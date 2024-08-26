using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_social_api.Migrations
{
    /// <inheritdoc />
    public partial class InnitSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "264e82f5-3d25-45a5-b6cf-d394574024cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c871b71-90d9-47e3-afcc-fe24afdd25e4");

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

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedOn", "UserProfileId" },
                values: new object[,]
                {
                    { 1, "Welcome to the system! Excited to have you here.", new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 2, "System maintenance scheduled for tonight.", new DateTime(2024, 8, 26, 3, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 3, "New feature release notes available in the documentation.", new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 4, "Reminder: Update your profile settings.", new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 5, "Check out the latest system reports.", new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 6, "Just pushed a new update to the repository.", new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 7, "Working on improving the API performance.", new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 8, "Dev meetup scheduled for next week.", new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 9, "New blog post on best coding practices.", new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 10, "Exploring new tools for developers.", new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 11, "Check out the latest design trends.", new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 12, "Redesigned the homepage for a client.", new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 13, "Design tips for creating effective UI.", new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 14, "How to use color theory in design.", new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 15, "Design project management tips.", new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 16, "New marketing strategy launched.", new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 17, "Top 5 tips for effective social media marketing.", new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 18, "Exploring new digital marketing tools.", new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 19, "Analyzing the latest marketing trends.", new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 20, "Effective strategies for increasing engagement.", new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 21, "Support hours extended this week.", new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 22, "New troubleshooting guide available.", new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 23, "How to resolve common support issues.", new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 24, "Tips for better customer support.", new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 25, "New features in the support portal.", new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Body", "CreatedOn", "PostId", "UserProfileId" },
                values: new object[,]
                {
                    { 1, "Great post! Really enjoyed the insights.", new DateTime(2024, 8, 24, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 1, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 2, "Thanks for sharing this information.", new DateTime(2024, 8, 25, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 2, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 3, "This was very helpful. Looking forward to more updates!", new DateTime(2024, 8, 23, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 3, "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 4, "I disagree with some of the points mentioned.", new DateTime(2024, 8, 22, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 4, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 5, "Can you provide more details on this topic?", new DateTime(2024, 8, 21, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 5, "ed677356-50e3-4640-8077-99db7f391a5b" },
                    { 6, "Amazing content! Keep up the great work.", new DateTime(2024, 8, 20, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 6, "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6" },
                    { 7, "Very informative, but could use some examples.", new DateTime(2024, 8, 19, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 7, "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb" },
                    { 8, "Nice article. I learned something new today!", new DateTime(2024, 8, 18, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 8, "0f6a348a-760e-4f67-8a72-fb1397b43f23" },
                    { 9, "Good read, but could be more concise.", new DateTime(2024, 8, 17, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 9, "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b" },
                    { 10, "Interesting perspective, thanks for sharing!", new DateTime(2024, 8, 16, 9, 32, 29, 935, DateTimeKind.Utc).AddTicks(9620), 10, "ed677356-50e3-4640-8077-99db7f391a5b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "271ae558-d7dd-447a-a7cf-a1ed8a68e92d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb57ceb2-053d-479e-82e2-7d0e2b4b5289");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "264e82f5-3d25-45a5-b6cf-d394574024cf", null, "Admin", "ADMIN" },
                    { "6c871b71-90d9-47e3-afcc-fe24afdd25e4", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c0abc36-66e8-4733-9120-e6493f4556e9", new DateTime(2024, 8, 25, 18, 21, 37, 456, DateTimeKind.Local).AddTicks(6836), "AQAAAAIAAYagAAAAEL4b2dsI+NVgjx4lUcjCYTZSJODgAIwD3C08Ff2xSYW9uSYYkpMK0aG6E6Lmhy2Kog==", "e70f7365-67a3-440a-9829-64ef8176818b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "165cb60a-1c29-4d68-95c6-716a8067eeda", new DateTime(2024, 8, 25, 18, 21, 37, 374, DateTimeKind.Local).AddTicks(6686), "AQAAAAIAAYagAAAAEJ3K/eTdrZ3WfG1AYFi1NRMPxqIEog1LmryAt0p9eMPnL2uDEl57eLwiVtdg4LHhzQ==", "bc20f919-d528-429c-9f72-3719036dc49e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34667dcf-2783-4230-8630-0815d5885366", new DateTime(2024, 8, 25, 18, 21, 37, 538, DateTimeKind.Local).AddTicks(7044), "AQAAAAIAAYagAAAAEM01W1CHSyctt9ZVaYdL2SErbWH1Nhp48ocZvh+rLa3L3a68eK9Aa+CXs7i+U+O0WQ==", "780ea171-2fd8-4a91-bc9f-81006831e954" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4c120d2-8c46-4b92-9783-e6fc4e480408", new DateTime(2024, 8, 25, 18, 21, 37, 292, DateTimeKind.Local).AddTicks(2227), "AQAAAAIAAYagAAAAEPROxpzCYuUkmJZm6mR0hd0lqgWLh+7ud2hxVZKs+k3tQRprk2RUqoXLjPItOceWrA==", "3e8b3e88-a09d-4328-82a0-084f9b5a4ecf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed677356-50e3-4640-8077-99db7f391a5b",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a2a5d3f-c630-4276-84d9-faa3fc2c51c6", new DateTime(2024, 8, 25, 18, 21, 37, 210, DateTimeKind.Local).AddTicks(5598), "AQAAAAIAAYagAAAAEBcrERI6eJaAxSG43zYIgiPZasyTPo96JPiIkljlx8v40oIvtIKaCte3LKu/Xpx1/Q==", "5bafa22b-48f9-4a94-9c12-d8ca81807857" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TwaddleGram.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Avatar", "Username" },
                values: new object[,]
                {
                    { 1, 0, "gwen" },
                    { 2, 0, "dave" },
                    { 3, 0, "brandon" },
                    { 4, 0, "alyssa" },
                    { 5, 0, "madi" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "Caption", "Photo", "UserID" },
                values: new object[,]
                {
                    { 1, "first post", 0, 1 },
                    { 2, "second post", 0, 1 },
                    { 3, "third post", 0, 1 },
                    { 4, "fourth post", 0, 1 },
                    { 5, "fifth post", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Content", "PostID" },
                values: new object[,]
                {
                    { 1, "first comment", 1 },
                    { 2, "second comment", 1 },
                    { 3, "third comment", 1 },
                    { 4, "fourth comment", 1 },
                    { 5, "fifth comment", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TwaddleGram.Migrations
{
    public partial class newseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Content",
                value: "They're great for swollen toes!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Content",
                value: "Ewww... I don't wanna smell your feet.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3,
                column: "Content",
                value: "You could wear them for a pedicure!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Content", "PostID" },
                values: new object[] { "Quite possibly the most disgusting thing ever.", 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Content", "PostID" },
                values: new object[] { "Gotta teach them early!", 13 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Caption", "Photo" },
                values: new object[] { "These boots are rockin'.", "https://twaddlegram.blob.core.windows.net/userpics/boots.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Caption", "Photo", "UserID" },
                values: new object[] { "Duckdog!", "https://twaddlegram.blob.core.windows.net/userpics/dog-duck.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Caption", "Photo", "UserID" },
                values: new object[] { "mmm....delish!", "https://twaddlegram.blob.core.windows.net/userpics/bubblegum.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Caption", "Photo", "UserID" },
                values: new object[] { "grrrr!", "https://twaddlegram.blob.core.windows.net/userpics/cthulhu.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Caption", "Photo", "UserID" },
                values: new object[] { "This child has a future in the domestic arts.", "https://twaddlegram.blob.core.windows.net/userpics/sweep.png", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Avatar",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "Avatar",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "Avatar",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "Avatar",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "Avatar",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Content",
                value: "first comment");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Content",
                value: "second comment");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3,
                column: "Content",
                value: "third comment");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Content", "PostID" },
                values: new object[] { "fourth comment", 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Content", "PostID" },
                values: new object[] { "fifth comment", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Caption", "Photo" },
                values: new object[] { "first post", "" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Caption", "Photo", "UserID" },
                values: new object[] { "second post", "", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Caption", "Photo", "UserID" },
                values: new object[] { "third post", "", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Caption", "Photo", "UserID" },
                values: new object[] { "fourth post", "", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Caption", "Photo", "UserID" },
                values: new object[] { "fifth post", "", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "Avatar",
                value: "");
        }
    }
}

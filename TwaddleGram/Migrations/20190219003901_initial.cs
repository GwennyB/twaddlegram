using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TwaddleGram.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caption = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    PostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Username" },
                values: new object[,]
                {
                    { 1, "gwen" },
                    { 2, "dave" },
                    { 3, "brandon" },
                    { 4, "alyssa" },
                    { 5, "madi" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "Caption", "Photo", "UserID" },
                values: new object[,]
                {
                    { 1, "These boots are rockin'.", "https://twaddlegram.blob.core.windows.net/userpics/boots.jpg", 1 },
                    { 2, "Duckdog!", "https://twaddlegram.blob.core.windows.net/userpics/dog-duck.jpg", 2 },
                    { 3, "mmm....delish!", "https://twaddlegram.blob.core.windows.net/userpics/bubblegum.jpg", 3 },
                    { 4, "grrrr!", "https://twaddlegram.blob.core.windows.net/userpics/cthulhu.jpg", 4 },
                    { 5, "This child has a future in the domestic arts.", "https://twaddlegram.blob.core.windows.net/userpics/sweep.png", 5 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Content", "PostID" },
                values: new object[,]
                {
                    { 1, "They're great for swollen toes!", 1 },
                    { 2, "Ewww... I don't wanna smell your feet.", 1 },
                    { 3, "You could wear them for a pedicure!", 1 },
                    { 4, "Quite possibly the worst thing ever.", 3 },
                    { 5, "Gotta teach them early!", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostID",
                table: "Comments",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserID",
                table: "Posts",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

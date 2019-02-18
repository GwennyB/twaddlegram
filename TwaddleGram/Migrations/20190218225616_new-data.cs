using Microsoft.EntityFrameworkCore.Migrations;

namespace TwaddleGram.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                column: "Content",
                value: "Quite possibly the worst thing ever.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4,
                column: "Content",
                value: "Quite possibly the most disgusting thing ever.");
        }
    }
}

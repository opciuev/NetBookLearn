using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guid主键.Migrations
{
    public partial class UpdateAuthorTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_author",
                table: "author",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_author",
                table: "author");

            migrationBuilder.RenameTable(
                name: "author",
                newName: "books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");
        }
    }
}

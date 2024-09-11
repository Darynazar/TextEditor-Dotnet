using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TextEditor.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTitleToDoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Docs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Docs");
        }
    }
}

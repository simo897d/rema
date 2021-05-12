using Microsoft.EntityFrameworkCore.Migrations;

namespace rema.Migrations
{
    public partial class Maybe6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Category",
                newName: "Names");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Names",
                table: "Category",
                newName: "Name");
        }
    }
}

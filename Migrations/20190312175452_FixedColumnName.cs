using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class FixedColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isAdmin",
                table: "User",
                newName: "IsAdmin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "User",
                newName: "isAdmin");
        }
    }
}

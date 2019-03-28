using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class RemovedIsAdminFromTwoEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "MainMember");

            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Dependant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "isAdmin",
                table: "MainMember",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isAdmin",
                table: "Dependant",
                nullable: false,
                defaultValue: 0);
        }
    }
}

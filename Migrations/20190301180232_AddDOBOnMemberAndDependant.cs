using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class AddDOBOnMemberAndDependant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "MainMember",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "Dependant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Dependant",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "MainMember");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Dependant");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Dependant");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Dependant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dependant",
                columns: table => new
                {
                    DependantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainMemberID = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    IDNumber = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependant", x => x.DependantID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dependant");
        }
    }
}

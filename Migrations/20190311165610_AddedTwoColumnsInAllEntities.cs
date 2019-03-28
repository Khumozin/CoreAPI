using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class AddedTwoColumnsInAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isAdmin",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "MainMember",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isAdmin",
                table: "MainMember",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Dependant",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isAdmin",
                table: "Dependant",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "User");

            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "MainMember");

            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "MainMember");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Dependant");

            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Dependant");
        }
    }
}

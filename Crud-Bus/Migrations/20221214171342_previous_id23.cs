using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Bus.Migrations
{
    public partial class previous_id23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "NewCarsDone");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "NewCarsDone",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarId",
                table: "NewCarsDone");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "NewCarsDone",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

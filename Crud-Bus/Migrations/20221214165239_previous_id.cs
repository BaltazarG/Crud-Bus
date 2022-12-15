using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Bus.Migrations
{
    public partial class previous_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

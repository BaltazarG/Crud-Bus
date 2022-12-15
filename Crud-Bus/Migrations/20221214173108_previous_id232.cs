using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Bus.Migrations
{
    public partial class previous_id232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "NewCarsDone",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "NewCarsDone");
        }
    }
}

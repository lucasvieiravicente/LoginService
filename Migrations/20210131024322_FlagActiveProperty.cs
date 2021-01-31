using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginService.Migrations
{
    public partial class FlagActiveProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FlagActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlagActive",
                table: "Users");
        }
    }
}

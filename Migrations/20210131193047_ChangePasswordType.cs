using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginService.Migrations
{
    public partial class ChangePasswordType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Password", "Users");
            migrationBuilder.AddColumn<byte[]>(name: "Password",
                                               table: "Users",
                                               type: "varbinary(max)",
                                               nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Password", "Users");
            migrationBuilder.AddColumn<string>(name: "Password",
                                               table: "Users",
                                               type: "nvarchar(40)",
                                               maxLength: 40,
                                               nullable: true);
        }
    }
}

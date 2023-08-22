using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GcashMonitoringWeb.Migrations
{
    public partial class ChangePaswordName1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginModel");

            migrationBuilder.RenameColumn(
                name: "Pasword",
                table: "tbl_login",
                newName: "Password");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "tbl_login",
                newName: "Pasword");

            migrationBuilder.CreateTable(
                name: "LoginModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRegister = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Emailaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RePassword = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginModel", x => x.Id);
                });
        }
    }
}

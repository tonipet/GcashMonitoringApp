using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GcashMonitoringWeb.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Pasword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRegister = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_login", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_login");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfKram.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestObjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TestString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestObjects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestObjects");
        }
    }
}

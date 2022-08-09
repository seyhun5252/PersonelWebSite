using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mg22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

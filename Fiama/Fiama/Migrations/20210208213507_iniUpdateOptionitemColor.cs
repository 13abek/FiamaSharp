using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiama.Migrations
{
    public partial class iniUpdateOptionitemColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "ProductOptions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "ProductOptions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}

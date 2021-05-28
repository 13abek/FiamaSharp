using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiama.Migrations
{
    public partial class ProductTableAddNewProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOffSales",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOffSales",
                table: "Products");
        }
    }
}

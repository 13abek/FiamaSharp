using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiama.Migrations
{
    public partial class initImageUpdateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderBy",
                table: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "ProductImages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "ProductImages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ProductImages");

            migrationBuilder.AddColumn<int>(
                name: "OrderBy",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SomeCompany.Erp.Migrations
{
    public partial class Created_Entidad_ProductosIsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppProductos",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppProductos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppProductos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppProductos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppProductos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppProductos");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppProductos");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppProductos");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppProductos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppProductos");
        }
    }
}

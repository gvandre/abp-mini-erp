using Microsoft.EntityFrameworkCore.Migrations;

namespace SomeCompany.Erp.Migrations
{
    public partial class Created_Entidad_Productos_columnCodProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoProducto",
                table: "AppProductos",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "AppProductos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabasaeManager.Migrations
{
    public partial class addprov : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedor",
                table: "Proveedor");

            migrationBuilder.RenameTable(
                name: "Proveedor",
                newName: "Proveedores");

            migrationBuilder.RenameIndex(
                name: "IX_Proveedor_ApodoProveedor",
                table: "Proveedores",
                newName: "IX_Proveedores_ApodoProveedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores");

            migrationBuilder.RenameTable(
                name: "Proveedores",
                newName: "Proveedor");

            migrationBuilder.RenameIndex(
                name: "IX_Proveedores_ApodoProveedor",
                table: "Proveedor",
                newName: "IX_Proveedor_ApodoProveedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedor",
                table: "Proveedor",
                column: "Id");
        }
    }
}

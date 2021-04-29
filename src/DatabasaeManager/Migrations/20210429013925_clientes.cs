using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DatabasaeManager.Migrations
{
    public partial class clientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaCompra",
                table: "Proveedores",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAlta",
                table: "Proveedores",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.CreateTable(
                name: "CategoriaMenus",
                columns: table => new
                {
                    IdCategoriaMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaMenus", x => x.IdCategoriaMenu);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaOpcions",
                columns: table => new
                {
                    IdCategoriaOpcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    IdCategoriaMenu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaOpcions", x => x.IdCategoriaOpcion);
                    table.ForeignKey(
                        name: "FK_CategoriaOpcions_CategoriaMenus_IdCategoriaMenu",
                        column: x => x.IdCategoriaMenu,
                        principalTable: "CategoriaMenus",
                        principalColumn: "IdCategoriaMenu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ClaveRegistro = table.Column<string>(type: "text", nullable: true),
                    RazonSocial = table.Column<string>(type: "text", nullable: false),
                    Rfc = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    Celular = table.Column<string>(type: "text", nullable: true),
                    Domicilio = table.Column<string>(type: "text", nullable: true),
                    Ciudad = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    Pais = table.Column<string>(type: "text", nullable: true),
                    Cp = table.Column<string>(type: "text", nullable: true),
                    Comentario = table.Column<string>(type: "text", nullable: false),
                    Paqueteria = table.Column<string>(type: "text", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime", nullable: true),
                    Banco = table.Column<string>(type: "text", nullable: true),
                    ClaveBancaria = table.Column<string>(type: "text", nullable: true),
                    CuentaBancaria = table.Column<string>(type: "text", nullable: true),
                    Representante = table.Column<string>(type: "text", nullable: false),
                    EmpresaTelefeono = table.Column<string>(type: "text", nullable: true),
                    EmpresaCelular = table.Column<string>(type: "text", nullable: false),
                    EmpresaEmail = table.Column<string>(type: "text", nullable: true),
                    EmpresaDomicilio = table.Column<string>(type: "text", nullable: true),
                    EmpresaCiudad = table.Column<string>(type: "text", nullable: true),
                    EmpresaEstado = table.Column<string>(type: "text", nullable: true),
                    EmpresaPais = table.Column<string>(type: "text", nullable: true),
                    EmpresaCp = table.Column<string>(type: "text", nullable: true),
                    DiasCredito = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    LimiteCredito = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    CategoriaIdCategoriaOpcion = table.Column<int>(type: "int", nullable: true),
                    IdNumeroPrecio = table.Column<int>(type: "int", nullable: false),
                    NumeroPrecioIdCategoriaOpcion = table.Column<int>(type: "int", nullable: true),
                    Activo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_CategoriaOpcions_CategoriaIdCategoriaOpcion",
                        column: x => x.CategoriaIdCategoriaOpcion,
                        principalTable: "CategoriaOpcions",
                        principalColumn: "IdCategoriaOpcion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_CategoriaOpcions_NumeroPrecioIdCategoriaOpcion",
                        column: x => x.NumeroPrecioIdCategoriaOpcion,
                        principalTable: "CategoriaOpcions",
                        principalColumn: "IdCategoriaOpcion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaOpcions_IdCategoriaMenu",
                table: "CategoriaOpcions",
                column: "IdCategoriaMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CategoriaIdCategoriaOpcion",
                table: "Clientes",
                column: "CategoriaIdCategoriaOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_NumeroPrecioIdCategoriaOpcion",
                table: "Clientes",
                column: "NumeroPrecioIdCategoriaOpcion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "CategoriaOpcions");

            migrationBuilder.DropTable(
                name: "CategoriaMenus");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaCompra",
                table: "Proveedores",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAlta",
                table: "Proveedores",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);
        }
    }
}

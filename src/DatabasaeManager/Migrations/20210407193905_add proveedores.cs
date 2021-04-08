using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DatabasaeManager.Migrations
{
    public partial class addproveedores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ApodoProveedor = table.Column<string>(type: "varchar(767)", nullable: true),
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
                    Notas = table.Column<string>(type: "text", nullable: false),
                    Paqueteria = table.Column<string>(type: "text", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime", nullable: false),
                    UltimaCompra = table.Column<DateTime>(type: "datetime", nullable: false),
                    Banco = table.Column<string>(type: "text", nullable: true),
                    ClaveBancaria = table.Column<string>(type: "text", nullable: true),
                    CuentaBancaria = table.Column<string>(type: "text", nullable: true),
                    Banco2 = table.Column<string>(type: "text", nullable: true),
                    ClaveBancaria2 = table.Column<string>(type: "text", nullable: true),
                    CuentaBancaria2 = table.Column<string>(type: "text", nullable: true),
                    Banco3 = table.Column<string>(type: "text", nullable: true),
                    ClaveBancaria3 = table.Column<string>(type: "text", nullable: true),
                    CuentaBancaria3 = table.Column<string>(type: "text", nullable: true),
                    Representante = table.Column<string>(type: "text", nullable: false),
                    RepresentanteTelefeono = table.Column<string>(type: "text", nullable: true),
                    RepresentanteCelular = table.Column<string>(type: "text", nullable: false),
                    RepresentanteEmail = table.Column<string>(type: "text", nullable: true),
                    RepresentanteDomicilio = table.Column<string>(type: "text", nullable: true),
                    RepresentanteCiudad = table.Column<string>(type: "text", nullable: true),
                    RepresentanteEstado = table.Column<string>(type: "text", nullable: true),
                    RepresentantePais = table.Column<string>(type: "text", nullable: true),
                    RepresentatneCp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_ApodoProveedor",
                table: "Proveedor",
                column: "ApodoProveedor",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proveedor");
        }
    }
}

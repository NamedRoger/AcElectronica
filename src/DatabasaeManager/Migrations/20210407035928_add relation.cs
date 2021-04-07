using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabasaeManager.Migrations
{
    public partial class addrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AplicacionUsuario",
                columns: table => new
                {
                    AplicacionesId = table.Column<int>(type: "int", nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplicacionUsuario", x => new { x.AplicacionesId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_AplicacionUsuario_Aplicaciones_AplicacionesId",
                        column: x => x.AplicacionesId,
                        principalTable: "Aplicaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplicacionUsuario_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AplicacionUsuario_UsuariosId",
                table: "AplicacionUsuario",
                column: "UsuariosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AplicacionUsuario");
        }
    }
}

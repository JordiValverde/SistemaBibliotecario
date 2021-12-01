using Microsoft.EntityFrameworkCore.Migrations;

namespace JLCS.SB.CapaDatos.Migrations
{
    public partial class PrimeraMigracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dni",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DniPrestamista",
                table: "PrestamoLibro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DniUsuario",
                table: "PrestamoLibro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DniPrestamista",
                table: "PrestamoEstudio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DniUsuario",
                table: "PrestamoEstudio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dni",
                table: "Prestamista",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dni",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DniPrestamista",
                table: "PrestamoLibro");

            migrationBuilder.DropColumn(
                name: "DniUsuario",
                table: "PrestamoLibro");

            migrationBuilder.DropColumn(
                name: "DniPrestamista",
                table: "PrestamoEstudio");

            migrationBuilder.DropColumn(
                name: "DniUsuario",
                table: "PrestamoEstudio");

            migrationBuilder.DropColumn(
                name: "Dni",
                table: "Prestamista");
        }
    }
}

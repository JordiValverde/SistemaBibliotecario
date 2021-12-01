using Microsoft.EntityFrameworkCore.Migrations;

namespace JLCS.SB.CapaDatos.Migrations
{
    public partial class CiudadCoordenadaImagenMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "CiudadActual",
                table: "Ciudades",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CiudadActual",
                table: "Ciudades",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}

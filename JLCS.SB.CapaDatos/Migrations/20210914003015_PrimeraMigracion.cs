using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JLCS.SB.CapaDatos.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    IdAutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutorApellido = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.IdAutor);
                });

            migrationBuilder.CreateTable(
                name: "Prestamista",
                columns: table => new
                {
                    IdPrestamista = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPrestamosEstudio = table.Column<int>(type: "int", nullable: false),
                    IdPrestamosLibro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamista", x => x.IdPrestamista);
                });

            migrationBuilder.CreateTable(
                name: "Tema",
                columns: table => new
                {
                    IdTema = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tema", x => x.IdTema);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Barrio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "PrestamoEstudio",
                columns: table => new
                {
                    IdPrestamoEstudio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPrestamo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdPrestamista = table.Column<int>(type: "int", nullable: false),
                    PrestamistaIdPrestamista = table.Column<int>(type: "int", nullable: true),
                    UsuarioEntidadIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestamoEstudio", x => x.IdPrestamoEstudio);
                    table.ForeignKey(
                        name: "FK_PrestamoEstudio_Prestamista_PrestamistaIdPrestamista",
                        column: x => x.PrestamistaIdPrestamista,
                        principalTable: "Prestamista",
                        principalColumn: "IdPrestamista",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrestamoEstudio_Usuario_UsuarioEntidadIdUsuario",
                        column: x => x.UsuarioEntidadIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrestamoLibro",
                columns: table => new
                {
                    IdPrestamoLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicioPrestamo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinPrestamo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObservacionInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacionFin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPrestamista = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    PrestamistaIdPrestamista = table.Column<int>(type: "int", nullable: true),
                    UsuarioEntidadIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestamoLibro", x => x.IdPrestamoLibro);
                    table.ForeignKey(
                        name: "FK_PrestamoLibro_Prestamista_PrestamistaIdPrestamista",
                        column: x => x.PrestamistaIdPrestamista,
                        principalTable: "Prestamista",
                        principalColumn: "IdPrestamista",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrestamoLibro_Usuario_UsuarioEntidadIdUsuario",
                        column: x => x.UsuarioEntidadIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sancion",
                columns: table => new
                {
                    IdSancion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SancionInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SancionFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioEntidadIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sancion", x => x.IdSancion);
                    table.ForeignKey(
                        name: "FK_Sancion_Usuario_UsuarioEntidadIdUsuario",
                        column: x => x.UsuarioEntidadIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTema = table.Column<int>(type: "int", nullable: false),
                    IdAutor = table.Column<int>(type: "int", nullable: false),
                    IdPrestamoLibro = table.Column<int>(type: "int", nullable: true),
                    IdPrestamoEstudio = table.Column<int>(type: "int", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroEjemplares = table.Column<int>(type: "int", nullable: false),
                    Estante = table.Column<int>(type: "int", nullable: false),
                    Casillero = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutorIdAutor = table.Column<int>(type: "int", nullable: true),
                    TemaIdTema = table.Column<int>(type: "int", nullable: true),
                    PrestamoEstudioEntidadIdPrestamoEstudio = table.Column<int>(type: "int", nullable: true),
                    PrestamoLibroEntidadIdPrestamoLibro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.IdLibro);
                    table.ForeignKey(
                        name: "FK_Libro_Autor_AutorIdAutor",
                        column: x => x.AutorIdAutor,
                        principalTable: "Autor",
                        principalColumn: "IdAutor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libro_PrestamoEstudio_PrestamoEstudioEntidadIdPrestamoEstudio",
                        column: x => x.PrestamoEstudioEntidadIdPrestamoEstudio,
                        principalTable: "PrestamoEstudio",
                        principalColumn: "IdPrestamoEstudio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libro_PrestamoLibro_PrestamoLibroEntidadIdPrestamoLibro",
                        column: x => x.PrestamoLibroEntidadIdPrestamoLibro,
                        principalTable: "PrestamoLibro",
                        principalColumn: "IdPrestamoLibro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libro_Tema_TemaIdTema",
                        column: x => x.TemaIdTema,
                        principalTable: "Tema",
                        principalColumn: "IdTema",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libro_AutorIdAutor",
                table: "Libro",
                column: "AutorIdAutor");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_PrestamoEstudioEntidadIdPrestamoEstudio",
                table: "Libro",
                column: "PrestamoEstudioEntidadIdPrestamoEstudio");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_PrestamoLibroEntidadIdPrestamoLibro",
                table: "Libro",
                column: "PrestamoLibroEntidadIdPrestamoLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_TemaIdTema",
                table: "Libro",
                column: "TemaIdTema");

            migrationBuilder.CreateIndex(
                name: "IX_PrestamoEstudio_PrestamistaIdPrestamista",
                table: "PrestamoEstudio",
                column: "PrestamistaIdPrestamista");

            migrationBuilder.CreateIndex(
                name: "IX_PrestamoEstudio_UsuarioEntidadIdUsuario",
                table: "PrestamoEstudio",
                column: "UsuarioEntidadIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PrestamoLibro_PrestamistaIdPrestamista",
                table: "PrestamoLibro",
                column: "PrestamistaIdPrestamista");

            migrationBuilder.CreateIndex(
                name: "IX_PrestamoLibro_UsuarioEntidadIdUsuario",
                table: "PrestamoLibro",
                column: "UsuarioEntidadIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Sancion_UsuarioEntidadIdUsuario",
                table: "Sancion",
                column: "UsuarioEntidadIdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Sancion");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "PrestamoEstudio");

            migrationBuilder.DropTable(
                name: "PrestamoLibro");

            migrationBuilder.DropTable(
                name: "Tema");

            migrationBuilder.DropTable(
                name: "Prestamista");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}

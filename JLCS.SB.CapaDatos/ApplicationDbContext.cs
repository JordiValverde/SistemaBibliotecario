using JLCS.SB.CapaEntidad;
using Microsoft.EntityFrameworkCore;


namespace JLCS.SB.CapaDatos
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString = "Data Source=SQL5080.site4now.net;Initial Catalog=db_a7ce2d_libreria;User Id=db_a7ce2d_libreria_admin;Password=eLPELUCASAPE1.";
        private Configuracion _configuracion;

        public ApplicationDbContext()
        {
            _configuracion = _configuracion.InstanciaConfiguracion();
            _connectionString = _configuracion.StringConnection();
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<LibroEntidad> Libro { get; set; }
        public DbSet<UsuarioEntidad> Usuario { get; set; }
        public DbSet<SancionEntidad> Sancion { get; set; }
        public DbSet<PrestamoLibroEntidad> PrestamoLibro { get; set; }
        public DbSet<TemaEntidad> Tema { get; set; }
        public DbSet<PrestamoEstudioEntidad> PrestamoEstudio { get; set; }
        public DbSet<PrestamistaEntidad> Prestamista { get; set; }
        public DbSet<AutorEntidad> Autor { get; set; }
        public DbSet<CiudadEntidad> Ciudades { get; set; }
        public DbSet<CoordenadasMapsEntidad> Coordenadas{ get; set; }
        public DbSet<ImagenEntidad> Imagenes{ get; set; }
    }
}

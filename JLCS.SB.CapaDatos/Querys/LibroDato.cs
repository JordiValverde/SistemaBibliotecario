using JLCS.SB.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaDatos.Querys
{
    public class LibroDato
    {
        public List<LibroEntidad> GetLibros()
        {
            List<LibroEntidad> ListaLibros = new List<LibroEntidad>()
            {
                new LibroEntidad() { IdLibro=1, IdAutor=1, IdPrestamoLibro=1, IdPrestamoEstudio=1, Titulo="los gansos", Tipo="aventuras", Categoria="fabula", NumeroEjemplares=10, Estante=1, Casillero=1, Observacion="Buen libro"},
                new LibroEntidad() { IdLibro = 2, IdAutor = 2, IdPrestamoLibro = 2, IdPrestamoEstudio = 2, Titulo = "History Dota", Tipo = "Entretnimiento", Categoria = "Historia", NumeroEjemplares = 20, Estante = 2, Casillero = 2, Observacion = "Gaaaa" },
            };

            return ListaLibros;
        }
        
        public LibroEntidad GetLibro(int id)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            LibroEntidad Libro;
            Libro = _context.Libro.FirstOrDefault(m => m.IdLibro == id);
            return Libro;
        }

    }
}

using JLCS.SB.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaDatos.Querys
{
    public class SancionDato
    {
        private static ApplicationDbContext _context;
        public SancionDato(ApplicationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<string> TipoDocumento()
        {
            IQueryable<string> TipoDocumentoQuery = from m in _context.Usuario
                                                    orderby m.TipoDocumento
                                                    select m.TipoDocumento;
            return TipoDocumentoQuery;
        }
        public IQueryable<SancionEntidad> GetSanciones()
        {
            var sanciones = from _sanciones in _context.Sancion
                           select _sanciones;
            return sanciones;
        }
        public SancionEntidad GetSancion(int id)
        {
            SancionEntidad _sancion = _context.Sancion.FirstOrDefault(m => m.IdSancion == id);
            return _sancion;
        }
    }
}

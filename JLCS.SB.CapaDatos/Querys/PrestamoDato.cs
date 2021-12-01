using JLCS.SB.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaDatos.Querys
{
    class PrestamoDato
    {
        private static ApplicationDbContext _context;
        public PrestamoDato()
        {
        }
        public IQueryable<string> TipoDocumento()
        {
            _context = new ApplicationDbContext();
            IQueryable<string> TipoDocumentoQuery = from m in _context.Usuario
                                                    orderby m.TipoDocumento
                                                    select m.TipoDocumento;
            return TipoDocumentoQuery;
        }
    }
}

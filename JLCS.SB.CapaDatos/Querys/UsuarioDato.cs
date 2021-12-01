using JLCS.SB.CapaEntidad;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaDatos.Querys
{
    public class UsuarioDato
    {
        private static ApplicationDbContext _context;
        public UsuarioDato(ApplicationDbContext Context)
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
        public IQueryable<UsuarioEntidad> GetUsuarios()
        {
            var usuarios = from _usuarios in _context.Usuario
                           select _usuarios;
            return usuarios;
        }
    }
}

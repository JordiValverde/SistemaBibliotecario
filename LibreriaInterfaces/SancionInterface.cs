using JLCS.SB.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaInterfaces
{
    public interface SancionInterface
    {
        List<SancionEntidad> ObtenerSanciones();
        SancionEntidad ObtenerSancion(int id);
        SancionEntidad AsignarFecha(SancionEntidad Sancion, bool estado);
        Task<bool> SancionarUsuario(SancionEntidad Sancion);
        Task<bool> RemoverSancionUsuario(SancionEntidad Sancion, int IdUsuario);
    }
}

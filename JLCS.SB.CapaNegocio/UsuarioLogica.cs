using System;
using JLCS.SB.CapaEntidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaInterfaces;

namespace JLCS.SB.CapaNegocio
{


    public class UsuarioLogica : UsuarioInterface
    {
        public List<UsuarioEntidad> ObtenerUsuarios()
        {
            return new List<UsuarioEntidad>() {
                new UsuarioEntidad(){ TipoDocumento = "DNI",
                    Nombre = "El Peluca",
                    Apellido = "Cuadros Reyes",
                    FechaIngreso = DateTime.Now,
                    Barrio = "San Cristobal",
                    Direccion = "Jr. Las Peras 304",
                    Telefono = 921345876,
                    Correo = "Correo@correo.com" },
                new UsuarioEntidad(){ TipoDocumento = "DNI",
                    Nombre = "El Peluca",
                    Apellido = "Cuadros Reyes",
                    FechaIngreso = DateTime.Now,
                    Barrio = "San Cristobal",
                    Direccion = "Jr. Las Peras 304",
                    Telefono = 921345876,
                    Correo = "Correo@correo.com" },
                new UsuarioEntidad(){ TipoDocumento = "DNI",
                    Nombre = "El Peluca",
                    Apellido = "Cuadros Reyes",
                    FechaIngreso = DateTime.Now,
                    Barrio = "San Cristobal",
                    Direccion = "Jr. Las Peras 304",
                    Telefono = 921345876,
                    Correo = "Correo@correo.com" }
            };
        }
    }
}

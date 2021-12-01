using JLCS.SB.CapaDatos;
using JLCS.SB.CapaDatos.Querys;
using JLCS.SB.CapaEntidad;
using LibreriaInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaNegocio
{
    public class DevolucionLogica : DevolucionInterface
    {
        private static DevolucionLogica Instancia;
        private LibroDato LibroQuery;
        protected LibroEntidad Libro { get; set; }
        public DevolucionLogica()
        {
            LibroQuery = new LibroDato();
        }
        public static DevolucionLogica ObtenerInstanciaSancion()
        {
            if (Instancia == null)
            {
                Instancia = new DevolucionLogica();
            }
            return Instancia;
        }
        public LibroEntidad SeleccionarLibro(int id)
        {
            try
            {
                Libro = LibroQuery.GetLibro(id);
            }
            catch
            {
                return Libro;
            }

            return Libro;
        }
        public bool DevolverLibro(int DNI, int id)
        {
            try
            {

            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

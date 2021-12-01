using JLCS.SB.CapaEntidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaDatos.Querys
{
    public class CiudadDato
    {
        public static ApplicationDbContext _context;
        public CiudadDato()
        {
        }
        public string ObtenerCiudad()
        {
            _context = new ApplicationDbContext();
            string Ciudad = "";
            bool estado = true;
            IQueryable<string> CiudadQuery = from m in _context.Ciudades
                                                    where (m.CiudadActual == estado)
                                                    select m.NombreCiudad;
            Ciudad = CiudadQuery.ToString();
            return Ciudad;
        }
        public bool VerificarCiudadActual()
        {
            _context = new ApplicationDbContext();
            List<bool> ListaCiudades;
            bool Estado = false;
            int Contador = 0;
            IQueryable<bool> CiudadActualQuery = from m in _context.Ciudades
                                                 select m.CiudadActual;
            ListaCiudades = CiudadActualQuery.ToList();
            foreach(var item in ListaCiudades)
            {
                if (item)
                {
                    Contador++;
                }
            }
            if (Contador > 1)
            {
                Estado = true;
                return Estado;
            }
            else
            {
                return Estado;
            }
        }
        public bool ActualizarCiudad(CiudadEntidad Ciudad)
        {
            _context = new ApplicationDbContext();
            bool Estado = false;
            try
            {
                _context.Ciudades.Update(Ciudad);
                _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                Estado = true;
            }
            
            return Estado;
        }
    }

}

using JLCS.SB.CapaDatos;
using JLCS.SB.CapaEntidad;
using LibreriaInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLCS.SB.CapaDatos.Querys;
using DesignByContract;

namespace JLCS.SB.CapaNegocio
{
    public class SancionLogica : SancionInterface
    {
        private readonly ApplicationDbContext _context;
        private static SancionLogica Instancia = null;
        protected SancionDato _sancion;
        protected UsuarioEntidad Usuario { get; set; }
        public SancionLogica(ApplicationDbContext context)
        {
            _context = context;
            _sancion = new SancionDato(_context);
        }
        public static SancionLogica ObtenerInstanciaSancion(ApplicationDbContext context)
        {
            if (Instancia == null)
            {
                Instancia = new SancionLogica(context);
            }
            return Instancia;
        }
        public List<SancionEntidad> ObtenerSanciones()
        {
            List<SancionEntidad> Sanciones = _sancion.GetSanciones().ToList();
            return Sanciones;
        }

        public SancionEntidad ObtenerSancion(int id)
        {
            SancionEntidad Sancion = _sancion.GetSancion(id);
            return Sancion;
        }

        public SancionEntidad AsignarFecha(SancionEntidad Sancion, bool estado)
        {
            Check.Require(Sancion != null);
            SancionEntidad _Sancion = Sancion;
            if (estado)
                if (_Sancion.SancionInicio <= DateTime.MinValue)
                    _Sancion.SancionInicio = DateTime.Now;
            else
                if(_Sancion.SancionFin <= DateTime.MinValue)
                    _Sancion.SancionFin = DateTime.Now;
            Check.Ensure(_Sancion.SancionInicio != DateTime.MinValue);
            return _Sancion;
        }

        public async Task<bool> SancionarUsuario(SancionEntidad Sancion)
        {
            
            Check.Require(Sancion.IdUsuario != 0);
            Boolean respuesta = false;
            if (Sancion.SancionInicio <= DateTime.MinValue)
            {
                Sancion = AsignarFecha(Sancion, true);
                _context.Sancion.Add(Sancion);
                try
                {
                    await _context.SaveChangesAsync();
                    respuesta = true;
                }
                catch (DbUpdateConcurrencyException)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public async Task<bool> RemoverSancionUsuario(SancionEntidad Sancion, int IdUsuario)
        {
            Check.Require(IdUsuario != 0);
            if (Sancion.IdUsuario == IdUsuario)
            {
                if (Sancion.SancionInicio > DateTime.MinValue)
                {
                    Sancion = AsignarFecha(Sancion, false);
                    _context.Sancion.Update(Sancion);
                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

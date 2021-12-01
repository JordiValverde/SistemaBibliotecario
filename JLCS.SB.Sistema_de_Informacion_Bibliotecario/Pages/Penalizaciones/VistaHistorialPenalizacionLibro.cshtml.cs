using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JLCS.SB.CapaEntidad;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using Newtonsoft.Json;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Pages.RegistroPenalizacion
{
    public class VistaHistorialPenalizacionLibroModel : PageModel
    {
        private readonly JLCS.SB.CapaDatos.ApplicationDbContext _context;

        public VistaHistorialPenalizacionLibroModel(JLCS.SB.CapaDatos.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<SancionEntidad> Sanciones { get; set; }
       public UsuarioEntidad Usuario { get; set; }

        public async Task/*<IActionResult>*/ OnGetAsync(int? id)
        {           
            Sanciones = await _context.Sancion.ToListAsync();
        }
    }
}

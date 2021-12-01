using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLCS.SB.CapaDatos;
using JLCS.SB.CapaEntidad;
using JLCS.SB.CapaNegocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Pages.PrestamoLibros
{
    public class DetallePrestamoModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DetallePrestamoModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public PrestamoLibroEntidad Prestamo { get; set; }
        public UsuarioEntidad Usuario { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
                Usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.IdUsuario == id);
                Prestamo = await _context.PrestamoLibro.FirstOrDefaultAsync(m => m.IdUsuario == id);
                if(Usuario == null)
                {
                    return NotFound();
                }else if(Prestamo == null)
                {
                    return NotFound();
                }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            _context.Attach(Prestamo).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return await OnGetAsync(Prestamo.IdUsuario);
            }
            return RedirectToPage("./ConsultarPrestamo");
        }
    }
}

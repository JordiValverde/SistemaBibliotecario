using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLCS.SB.CapaEntidad;
using JLCS.SB.CapaNegocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Pages.PrestamoLibros
{
    public class RegistrarPrestamoModel : PageModel
    {
        private readonly JLCS.SB.CapaDatos.ApplicationDbContext _context;
        public RegistrarPrestamoModel(JLCS.SB.CapaDatos.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<LibroEntidad> Libro { get; set; }
        public IList<UsuarioEntidad> Usuario { get; set; }
        [BindProperty]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            var usuarios = from u in _context.Usuario
                           select u;
            var libros = from l in _context.Libro
                         select l;
            if (!string.IsNullOrEmpty(SearchString))
            {
                usuarios = usuarios.Where(s => s.Nombre.Contains(SearchString));
                libros = libros.Where(s => s.Titulo.Contains(SearchString));
            }
               Usuario = await usuarios.ToListAsync();
               Libro = await libros.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete (int id)
        {
            var _Usuario = await _context.Usuario.FindAsync(id);
            if (_Usuario == null)
            {
                return NotFound();
            }
            _context.Usuario.Remove(_Usuario);
            await _context.SaveChangesAsync();
            return RedirectToPage("RegistrarPrestamo");
        }
        [BindProperty]
        public UsuarioEntidad Usuarios { get; set; }
    }
}

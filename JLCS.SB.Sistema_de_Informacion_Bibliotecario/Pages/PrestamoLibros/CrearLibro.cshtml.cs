using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLCS.SB.CapaEntidad;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
//using Rotativa.AspNetCore;
namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Pages.PrestamoLibros
{
    public class CrearLibroModel : PageModel
    {
        private readonly CapaDatos.ApplicationDbContext _context;
        public CrearLibroModel (CapaDatos.ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public LibroEntidad Libro { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            try{
                if (!ModelState.IsValid)
                {
                    return Page();
                }
            }catch
            {
                return RedirectToPage("Error404");
            }
            _context.Add(Libro);
            await _context.SaveChangesAsync();
            return RedirectToPage("RegistrarPrestamo");
        }
    }
}

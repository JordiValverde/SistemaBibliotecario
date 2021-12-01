using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLCS.SB.CapaEntidad;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Pages.PrestamoLibros
{
    public class EditarLibroModel : PageModel
    {
        private readonly CapaDatos.ApplicationDbContext _context;
        public EditarLibroModel(CapaDatos.ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public LibroEntidad Libro { get; set; }
        public async Task OnGet(int id)
        {
            Libro = await _context.Libro.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var LibroDesdedb = await _context.Libro.FindAsync(Libro.IdLibro);
                    LibroDesdedb.Titulo = Libro.Titulo;
                    LibroDesdedb.Tema = Libro.Tema;
                    LibroDesdedb.NumeroEjemplares = Libro.NumeroEjemplares;
                    LibroDesdedb.Autor = Libro.Autor;
                    LibroDesdedb.Categoria = Libro.Categoria;
                    LibroDesdedb.Estante = Libro.Estante;
                    LibroDesdedb.Casillero = Libro.Casillero;
                    LibroDesdedb.Tipo = Libro.Tipo;
                    LibroDesdedb.Observacion = Libro.Observacion;

                    await _context.SaveChangesAsync();
                    return RedirectToPage("RegistrarPrestamo");
                }
            }
            catch 
            {
                return RedirectToPage();
            }
            return RedirectToPage();
        }
    }
}

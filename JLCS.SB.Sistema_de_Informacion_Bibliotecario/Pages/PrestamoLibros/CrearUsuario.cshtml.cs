using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLCS.SB.CapaDatos.Querys;
using JLCS.SB.CapaEntidad;
using JLCS.SB.Sistema_de_Informacion_Bibliotecario.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Pages.PrestamoLibros
{
    public class CrearUsuarioModel : PageModel
    {
        private readonly CapaDatos.ApplicationDbContext _context;
        public CrearUsuarioModel(CapaDatos.ApplicationDbContext context)
        {
            _context = context;
        }        
        [BindProperty]
        public UsuarioEntidad Usuario { get; set; }
            public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    //BasicNotification("Usuario Creado", NotificationType.Success, "Correcto!");
                    return Page();
                }
            }
            catch
            {
                return RedirectToPage("Error404");
            }
            _context.Add(Usuario);
            await _context.SaveChangesAsync();
            return RedirectToPage("RegistrarPrestamo");
        }
    }
}

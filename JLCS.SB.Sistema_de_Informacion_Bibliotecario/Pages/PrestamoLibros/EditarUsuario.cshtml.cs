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
    public class EditarUsuarioModel : PageModel
    {
        private readonly CapaDatos.ApplicationDbContext _context;
        public EditarUsuarioModel(CapaDatos.ApplicationDbContext context)
        {
            _context=context;
        }
        [BindProperty]
        public UsuarioEntidad Usuario { get; set; }
        public async Task OnGet(int id)
        {
            Usuario = await _context.Usuario.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var UsuarioDesdeDb = await _context.Usuario.FindAsync(Usuario.IdUsuario);
                    UsuarioDesdeDb.TipoDocumento = Usuario.TipoDocumento;
                    UsuarioDesdeDb.Dni = Usuario.Dni;
                    UsuarioDesdeDb.Nombre = Usuario.Nombre;
                    UsuarioDesdeDb.Apellido = Usuario.Apellido;
                    UsuarioDesdeDb.Telefono = Usuario.Telefono;
                    UsuarioDesdeDb.Direccion = Usuario.Direccion;
                    UsuarioDesdeDb.Barrio = Usuario.Barrio;
                    UsuarioDesdeDb.Correo = Usuario.Correo;
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

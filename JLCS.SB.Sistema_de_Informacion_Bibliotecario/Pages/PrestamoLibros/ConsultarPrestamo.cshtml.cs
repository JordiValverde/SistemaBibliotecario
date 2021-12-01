using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLCS.SB.CapaEntidad;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JLCS.SB.CapaNegocio;
using JLCS.SB.CapaDatos;
using JLCS.SB.CapaDatos.Querys;
namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Pages.PrestamoLibros
{
    public class ConsultarPrestamoModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UsuarioDato _usuarios;
        private readonly SancionDato _sancionDato;
        private readonly SancionLogica _sancion;
        public ConsultarPrestamoModel(ApplicationDbContext context)
        {
            _sancion = new SancionLogica(context);
            _sancionDato = new SancionDato(context);
            _context = context;
            _usuarios = new UsuarioDato(_context);
        }
        public IList<LibroEntidad> Libro { get; set; }
        public IList<UsuarioEntidad> Usuarios { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList TipoDocumentos { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TipoDocumento { get; set; }
        [BindProperty(SupportsGet = true)]
        public IList<SancionEntidad> Sanciones { get; set; }
        public async Task OnGetAsync()
        {
            var SancionesQuery = _sancionDato.GetSanciones();
            IQueryable<string> TipoDocumentoQuery = _usuarios.TipoDocumento();
            var usuarios = _usuarios.GetUsuarios();
            if (!string.IsNullOrEmpty(SearchString))
            {
                usuarios = usuarios.Where(s => s.Dni.ToString().Contains(SearchString));
            }else
            {
                RedirectToPage("../Errores/Error404NotFound");
            }
            if (!string.IsNullOrEmpty(TipoDocumento))
            {
                usuarios = usuarios.Where(x => x.TipoDocumento == TipoDocumento);
            }
            else
            {
                RedirectToPage("../Errores/Error404NotFound");
            }
            TipoDocumentos = new SelectList(await TipoDocumentoQuery.Distinct().ToListAsync());
            Usuarios = await usuarios.ToListAsync();
            Sanciones = await SancionesQuery.ToListAsync();
        }
        [BindProperty]
        public SancionEntidad Sancion { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            await _sancion.SancionarUsuario(Sancion);
            return RedirectToPage("/Penalizaciones/VistaHistorialPenalizacionLibro");
        }
    }    
}

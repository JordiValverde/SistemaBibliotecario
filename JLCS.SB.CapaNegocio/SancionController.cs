using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JLCS.SB.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JLCS.SB.CapaEntidad
{
    [Route("Controller")]
    public class SancionController : Controller
    {
        private static ApplicationDbContext DbContext;
        // GET: SancionController
        public SancionController(ApplicationDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        [Route("SancionController")]
        public ActionResult ConsultaPrestamo()
        {
            DateTime fecha = System.DateTime.Now;
            UsuarioEntidad Usuario = new UsuarioEntidad()
            {
                TipoDocumento = "DNI",
                Nombre = "El Peluca",
                Apellido = "Cuadros Reyes",
                FechaIngreso = fecha,
                Barrio = "San Cristobal",
                Direccion = "Jr. Las Peras 304",
                Telefono = 921345876,
                Correo = "Correo@correo.com"
            };
            DbContext.Usuario.Add(Usuario);
            DbContext.SaveChanges();
            ViewBag.Usuarios = DbContext.Usuario.ToList();
            return View("ConsultaPrestamo");
        }

        // GET: SancionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SancionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SancionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SancionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SancionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SancionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SancionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

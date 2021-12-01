using API_Libros.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LIbros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibrosController : ControllerBase
    {
        [HttpGet("libros/all")]
        public ActionResult<IEnumerable<Libro>> GettAll()
        {
            return new[]
            {
                new Libro {Id = 1, autor = "Miguel de Cervantes", nombre = "El ingenioso caballero Don Quijote de la Mancha", añopubicacion = 1605},
                new Libro {Id = 2, autor = "Cesar Vallejo", nombre = "Trilce", añopubicacion = 1922},
                new Libro {Id = 3, autor = "Alfredo Bryce Echenique", nombre = "Un Mundo para Julius", añopubicacion = 1970},
                new Libro {Id = 4, autor = "Julio Ramon Ribeyro", nombre = "Los gallinazos sin plumas", añopubicacion = 1955},
                new Libro {Id = 5, autor = "Fiódor Dostoyevski", nombre = "Crimen y Castigo", añopubicacion = 1866},

            };
        }

    }
}
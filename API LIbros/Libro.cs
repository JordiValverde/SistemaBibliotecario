using System;

namespace API_Libros.Controllers
{
    public class Libro
    {
        public int Id { set; get; }

        public string autor { set; get; }

        public string nombre { set; get; }

        public int añopubicacion { set; get; }
    }
}
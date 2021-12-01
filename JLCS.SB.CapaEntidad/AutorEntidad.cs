using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaEntidad
{
    public class AutorEntidad
    {
        [Key]
        [Required(ErrorMessage = "Error")]
        public int IdAutor { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Nombre")]
        public string AutorNombre { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Apellido")]
        public string AutorApellido { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaEntidad
{
    public class PrestamoEstudioEntidad
    {
        [Key]
        public int IdPrestamoEstudio { get; set; }

        [Required(ErrorMessage = "Error")]
        [Display(Name = "Fecha/Hora de Prestamo")]
        public DateTime FechaPrestamo { get; set; }

        [Required(ErrorMessage = "Error")]
        [Display(Name = "Observacion")]
        public string Observacion { get; set; }
        [Required(ErrorMessage = "Error")]
        public int DniPrestamista { get; set; }
        [Required(ErrorMessage = "Error")]
        public int DniUsuario { get; set; }



        [Required(ErrorMessage = "Error")]
        [Display(Name = "Usuario")]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Prestamista")]
        public int IdPrestamista { get; set; }



        [Required(ErrorMessage = "Error")]
        [Display(Name = "Libro")]
        public virtual List<LibroEntidad> Libros { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Prestamista")]
        public virtual PrestamistaEntidad Prestamista { get; set; }

    }
}

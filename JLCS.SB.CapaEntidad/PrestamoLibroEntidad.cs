using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaEntidad
{
    public class PrestamoLibroEntidad
    {
        [Key]
        public int IdPrestamoLibro { get; set; }


        [Required(ErrorMessage = "Error")]
        [Display(Name = "Fecha/Hora de Prestamo")]
        public DateTime FechaInicioPrestamo { get; set; }

        [Required(ErrorMessage = "Error")]
        [Display(Name = "Fecha/Hora de Devolucion")]
        public DateTime FechaFinPrestamo { get; set; }

        [Required(ErrorMessage = "Error")]
        [Display(Name = "Observacion inicial")]
        public string ObservacionInicio { get; set; }

        [Required(ErrorMessage = "Error")]
        [Display(Name = "Observacion final")]
        public string ObservacionFin { get; set; }
        public int DniPrestamista { get; set; }
        [Required(ErrorMessage = "Error")]
        public int DniUsuario { get; set; }



        [Required(ErrorMessage = "Error")]
        [Display(Name = "Prestamista")]
        public int IdPrestamista { get; set; }

        [Required(ErrorMessage = "Error")]
        [Display(Name = "Usuario")]
        public int IdUsuario { get; set; }



        [Required(ErrorMessage = "Error")]
        [Display(Name = "Libro")]
        public virtual List<LibroEntidad> Libros { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Prestamista")]
        public virtual PrestamistaEntidad Prestamista { get; set; }

    }
}

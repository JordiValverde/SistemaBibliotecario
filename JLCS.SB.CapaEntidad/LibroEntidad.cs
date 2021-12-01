using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaEntidad
{
    public class LibroEntidad
    {
        [Key]
        [Required(ErrorMessage = "Error")]
        public int IdLibro { get; set; }


        [Required(ErrorMessage = "Error")]
        public int IdTema { get; set; }
        [Required(ErrorMessage = "Error")]
        public int IdAutor { get; set; }
        public int IdPrestamoLibro { get; set; }
        public int IdPrestamoEstudio { get; set; }



        [Display(Name = "Titulo")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
        
        
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Cantidad de Ejemplares")]
        public int NumeroEjemplares { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Numero de Estante")]
        public int Estante { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Numero de Casillero")]
        public int Casillero { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Observaciones")]
        public string Observacion { get; set; }

        public virtual AutorEntidad Autor { get; set; }
        public virtual TemaEntidad Tema { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaEntidad
{
    public class PrestamistaEntidad
    {
        [Key]
        [Required(ErrorMessage ="Error")]
        public int IdPrestamista { get; set; }
        [Required(ErrorMessage = "Error")]
        public int Dni { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Tipo de Documento")]
        public string TipoDocumento { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [DataType(DataType.Password,ErrorMessage = "Error")]
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Perfil")]
        public string Perfil { get; set; }


        public int IdPrestamosEstudio { get; set; }
        public int IdPrestamosLibro { get; set; }



    }
}

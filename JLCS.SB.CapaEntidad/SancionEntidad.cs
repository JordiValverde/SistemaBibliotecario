using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JLCS.SB.CapaEntidad
{
    public class SancionEntidad
    {
        [Key]
        [Required(ErrorMessage = "Error")]
        public int IdSancion { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Inicio de Sancion")]
        public DateTime SancionInicio { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Fin de Sancion")]
        
        public DateTime SancionFin { get; set; }
        public int IdUsuario { get; set; }
    }
}

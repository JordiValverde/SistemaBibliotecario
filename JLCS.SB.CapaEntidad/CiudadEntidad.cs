using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaEntidad
{
    public class CiudadEntidad
    {
        [Key]
        [Required]
        public int IdCiudad { get; set; }
        [Required]
        public string NombreCiudad { get; set; }
        public Boolean CiudadActual { get; set; }
    }
}

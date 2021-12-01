using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaEntidad
{
    public class CoordenadasMapsEntidad
    {
        [Key]
        [Required]
        public int IdCoordenada { get; set; }
        [Required]
        public string Longitud { get; set; }
        [Required]
        public string Latitud { get; set; }
    }
}

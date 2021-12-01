using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCS.SB.CapaEntidad
{
    public class TemaEntidad
    {
        [Key]
        [Required(ErrorMessage = "Error")]
        public int IdTema { get; set; }
        [Display(Name = "Tema")]
        public string Tema { get; set; }
    }
}

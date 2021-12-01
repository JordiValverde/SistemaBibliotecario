using System;
using System.ComponentModel.DataAnnotations;

namespace JLCS.SB.CapaEntidad
{
    public class ImagenEntidad
    {
        [Key]
        [Required]
        public int IdImagen { get; set; }
        [Required]
        public string UrlImagen { get; set; }
    }
}

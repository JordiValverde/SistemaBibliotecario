using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JLCS.SB.CapaEntidad
{
    public class UsuarioEntidad
    {
        [Key]
        [Required(ErrorMessage = "Error")]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Error")]
        public int Dni { get; set; }
        
        [DataType(DataType.Text, ErrorMessage = "Error")]
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Tipo de Documento")]
        public string TipoDocumento { get; set; }
        
        [DataType(DataType.Text, ErrorMessage = "Error")]
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        
        [DataType(DataType.Text, ErrorMessage = "Error")]
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        
        [DataType(DataType.DateTime, ErrorMessage = "Error")]
        //[Required(ErrorMessage = "Error")]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "Error")]
        [Display(Name = "Barrio")]
        public string Barrio { get; set; }
        
        [DataType(DataType.Text, ErrorMessage = "Error")]
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        
        [DataType(DataType.PhoneNumber, ErrorMessage = "Error")]
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Telefono")]
        public int Telefono { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Error")]
        [Display(Name = "Correo")]
        public string Correo { get; set; }



        public virtual List<PrestamoEstudioEntidad> PrestamosEstudio { get; set; }
        public virtual List<PrestamoLibroEntidad> PrestamosLibro { get; set; }
        public virtual List<SancionEntidad> Sanciones { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sicaab.Models
{
    public class Clientes
    {
        [Key]
        public int id_cliente { get; set; }
        [Required]
        [Display(Name ="No. Documento")]
        [MinLength(6), MaxLength(20)]
        public String dni { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Apellido { get; set; }
        [Required]
        [Range(0, 199)]
        public int Edad { get; set; }
        [Required]
        public String Correo { get; set; }
        [Required]
        [MinLength(6), MaxLength(10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Solo puede escribir numeros")]
        public String Celular { get; set; }

    }
}
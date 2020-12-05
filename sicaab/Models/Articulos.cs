using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sicaab.Models
{
    public class Articulos
    {
        [Key]
        public int id_articulo { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public String categoria { get; set; }
        [Required]
        public String descripcion { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public Boolean condicion { get; set; }

    }
}
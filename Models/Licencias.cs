using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioTI.Models
{
    [Table("Licencias")]
    public class Licencias
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        [Display(Name ="Codigo del Producto")]
        public string CodigoProducto { get; set; }
        [Display(Name = "Inicio de Vigencia")]
        public DateTime InicioVigencia { get; set; }
        [Display(Name = "Fin de Vigencia")]
        public DateTime FinVigencia { get; set; }
    }
}

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
        [Required(ErrorMessage = "Debes ingresar la marca de la licencia")]
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Debes ingresar el tipo de licencia")]
        public string Tipo { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        [Display(Name ="Codigo del Producto")]
        public string CodigoProducto { get; set; }
        [Display(Name = "Inicio de Vigencia")]
        [Required(ErrorMessage ="Debes ingresar una fecha valida")]
        public DateTime InicioVigencia { get; set; }
        [Display(Name = "Fin de Vigencia")]
        [Required(ErrorMessage = "Debes ingresar una fecha valida")]
        public DateTime FinVigencia { get; set; }
        [Required(ErrorMessage ="Debes ingresar una cantidad de licencias")]
        public int Cantidad { get; set; }
    }
}

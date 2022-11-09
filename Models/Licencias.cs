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
        public int Cantidad { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioTI.Models
{
    [Table("InvCatTipoConexion")]
    public class InvCatTipoConexion
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Debe ingresar el tipo de conexión")]
        [Display(Name ="Tipo de Conexión")]
        public string TipoConexion { get; set; }
    }
}

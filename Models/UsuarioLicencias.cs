using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioTI.Models
{
    [Table("UsuarioLicencias")]
    public class UsuarioLicencias
    {
        [Key]
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        [ForeignKey("IdAsignacion")]
        public int IdAsignacion { get; set; }
    }
}

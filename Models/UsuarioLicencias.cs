using System;
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
        [Display(Name = "Usuario Asignado")]
        public bool Asignado { get; set; }
        [Display(Name = "Fecha de Inicio de Asignación")]
        public DateTime FechaInicioAsignacion { get; set; }
        [Display(Name = "Fecha de Fin de Asignación")]
        public DateTime FechaFinAsignacion { get; set; }
    }
}

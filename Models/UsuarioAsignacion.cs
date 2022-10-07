using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioTI.Models
{
    [Table("UsuarioAsignacion")]
    public class UsuarioAsignacion
    {
        [Key]
        public int idUsuarioAsignacion { get; set; }
        public int idAsignacion { get; set; }
        [Display(Name ="Fecha de Inicio de Asignación")]
        public DateTime fechaInicioAsignacion { get; set; }
        [Display(Name = "Fecha de Fin de Asignación")]
        public DateTime fechaFinAsignacion { get; set; }
        [Display(Name ="Usuario Asignado")]
        public bool asignado { get; set; }
        [Display(Name ="Id del Empleado")]
        public int idEmpleado { get; set; }
    }
}

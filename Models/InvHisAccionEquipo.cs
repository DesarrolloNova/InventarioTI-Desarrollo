using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InventarioTI.Models
{
    [Table("InvHisAccionEquipo")]
    public class InvHisAccionEquipo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debes ingresar la fecha de inicio")]
        [Display(Name = "Fecha de inicio")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "Debes ingresar la fecha de fin")]
        [Display(Name = "Fecha de fin")]
        public DateTime FechaFin { get; set; }
        [Display(Name = "Tipo de Proceso")]
        public string TipoProceso { get; set; }
        [ForeignKey("IdEquipo")]
        public int IdEquipo { get; set; }
        [Display(Name = "Usuario que Registró")]
        public int IdUsuarioRegistro { get; set; }
    }
}

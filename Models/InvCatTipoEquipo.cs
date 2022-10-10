using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvCatTipoEquipo
    {
        public int Id { get; set; }
        [Display(Name ="Tipo de Equipo")]
        [Required(ErrorMessage ="Debes ingresar el tipo de equipo")]
        public string Tipo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvCatEstatusEquipo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Debes ingresar el nombre del estatus")]
        public string Estatus { get; set; }
        public string Descripcion { get; set; }
    }
}

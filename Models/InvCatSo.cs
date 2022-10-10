using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvCatSo
    {
        public int Id { get; set; }
        [DisplayName("Sistema Operativo")]
        [Required(ErrorMessage ="Debes ingresar el nombre del sistema operativo")]
        public string SistemaOperativo { get; set; }
    }
}

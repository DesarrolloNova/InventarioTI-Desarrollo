using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class RelLoginSistemaUsuario
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public bool? Ticket { get; set; }
        public bool? Inventario { get; set; }

        public virtual TabUsuario IdUsuarioNavigation { get; set; }
    }
}

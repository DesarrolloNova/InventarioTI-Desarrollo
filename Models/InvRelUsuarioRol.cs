using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvRelUsuarioRol
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }

        public virtual InvCatRol IdRolNavigation { get; set; }
        public virtual TabUsuario IdUsuarioNavigation { get; set; }
    }
}

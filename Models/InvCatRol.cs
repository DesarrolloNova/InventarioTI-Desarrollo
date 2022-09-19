using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvCatRol
    {
        public InvCatRol()
        {
            InvRelRolSistemas = new HashSet<InvRelRolSistema>();
            InvRelUsuarioRols = new HashSet<InvRelUsuarioRol>();
        }

        public int Id { get; set; }
        public string Rol { get; set; }

        public virtual ICollection<InvRelRolSistema> InvRelRolSistemas { get; set; }
        public virtual ICollection<InvRelUsuarioRol> InvRelUsuarioRols { get; set; }
    }
}

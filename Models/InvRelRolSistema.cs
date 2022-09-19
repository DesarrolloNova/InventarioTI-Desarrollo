using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvRelRolSistema
    {
        public int Id { get; set; }
        public int? IdRol { get; set; }
        public string Modulo { get; set; }
        public string SubModulo { get; set; }

        public virtual InvCatRol IdRolNavigation { get; set; }
    }
}

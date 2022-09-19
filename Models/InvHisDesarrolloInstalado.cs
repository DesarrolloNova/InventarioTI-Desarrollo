using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvHisDesarrolloInstalado
    {
        public int Id { get; set; }
        public int IdSistema { get; set; }
        public int IdAsignacion { get; set; }

        public virtual InvHisAsignacionEquipo IdAsignacionNavigation { get; set; }
    }
}

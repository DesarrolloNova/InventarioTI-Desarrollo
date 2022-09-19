using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvHisGrupoUsuario
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdAsignacion { get; set; }

        public virtual InvHisAsignacionEquipo IdAsignacionNavigation { get; set; }
        public virtual TabUsuario IdUsuarioNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvHisSoporte
    {
        public int Id { get; set; }
        public string JsonDatosMovil { get; set; }
        public string Problema { get; set; }
        public string Observaciones { get; set; }
        public bool Estatus { get; set; }
        public int IdEquipo { get; set; }
        public int IdUsuarioEmisor { get; set; }
        public int? IdUsuarioResuelve { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaResolucion { get; set; }

        public virtual InvTabEquipo IdEquipoNavigation { get; set; }
        public virtual TabUsuario IdUsuarioEmisorNavigation { get; set; }
        public virtual TabUsuario IdUsuarioResuelveNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvHisAccionEquipo
    {
        public InvHisAccionEquipo()
        {
            InvHisPlantillaInstalacions = new HashSet<InvHisPlantillaInstalacion>();
            InvHisPlantillaMantenimientos = new HashSet<InvHisPlantillaMantenimiento>();
        }

        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string TipoProceso { get; set; }
        public int? IdAsignacion { get; set; }
        public int? IdEquipo { get; set; }
        public int? IdUsuarioRegistro { get; set; }

        public virtual InvHisAsignacionEquipo IdAsignacionNavigation { get; set; }
        public virtual InvTabEquipo IdEquipoNavigation { get; set; }
        public virtual TabUsuario IdUsuarioRegistroNavigation { get; set; }
        public virtual ICollection<InvHisPlantillaInstalacion> InvHisPlantillaInstalacions { get; set; }
        public virtual ICollection<InvHisPlantillaMantenimiento> InvHisPlantillaMantenimientos { get; set; }
    }
}

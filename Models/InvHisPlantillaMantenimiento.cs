using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvHisPlantillaMantenimiento
    {
        public int Id { get; set; }
        public bool DepuracionProgramas { get; set; }
        public bool Funciona { get; set; }
        public bool LimpiezaTemporales { get; set; }
        public bool DesfragmentacionHdd { get; set; }
        public bool EscaneoAntivirus { get; set; }
        public bool RevisionArchivos { get; set; }
        public bool SoftwareSinLicencia { get; set; }
        public bool LicenciasActivas { get; set; }
        public bool Perifericos { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdAccionEquipo { get; set; }

        public virtual InvHisAccionEquipo IdAccionEquipoNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvHisPlantillaInstalacion
    {
        public int Id { get; set; }
        public bool AntivirusInstalado { get; set; }
        public string Antivirus { get; set; }
        public bool PaqueteriaOfficeInstalado { get; set; }
        public string PaqueteriaOffice { get; set; }
        public bool OtrasAplicaciones { get; set; }
        public bool UsoPortales { get; set; }
        public bool SeEliminaronAplicaciones { get; set; }
        public double HddDisponible { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdAccionEquipo { get; set; }
    }
}

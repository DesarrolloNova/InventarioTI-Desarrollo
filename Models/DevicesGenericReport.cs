using InventarioTI.Models.EXT_WEB;
using System.Collections.Generic;

namespace InventarioTI.Models
{
    public class DevicesGenericReport
    {
        public List<InvTabEquipo> Equipos { get; set; }
        public List<InvHisAsignacionEquipo> Asignaciones { get; set; }
        public List<UsuarioAsignacion> usuariosAsignaciones { get; set; }
        public List<RH00_Usuarios> Usuarios { get; set; }
    }
}

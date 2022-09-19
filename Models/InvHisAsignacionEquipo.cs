using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvHisAsignacionEquipo
    {
        public InvHisAsignacionEquipo()
        {
            InvHisAccionEquipos = new HashSet<InvHisAccionEquipo>();
            InvHisDesarrolloInstalados = new HashSet<InvHisDesarrolloInstalado>();
            InvHisGrupoUsuarios = new HashSet<InvHisGrupoUsuario>();
        }

        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool EnDominio { get; set; }
        public string TipoConexion { get; set; }
        public string Ip { get; set; }
        public int IdEquipo { get; set; }
        public int IdPlanta { get; set; }
        public int IdDepartamento { get; set; }
        public bool Activo { get; set; }

        public virtual InvTabEquipo IdEquipoNavigation { get; set; }
        public virtual ICollection<InvHisAccionEquipo> InvHisAccionEquipos { get; set; }
        public virtual ICollection<InvHisDesarrolloInstalado> InvHisDesarrolloInstalados { get; set; }
        public virtual ICollection<InvHisGrupoUsuario> InvHisGrupoUsuarios { get; set; }
    }
}

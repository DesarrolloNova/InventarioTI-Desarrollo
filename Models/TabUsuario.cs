using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class TabUsuario
    {
        public TabUsuario()
        {
            InvHisAccionEquipos = new HashSet<InvHisAccionEquipo>();
            InvHisGrupoUsuarios = new HashSet<InvHisGrupoUsuario>();
            InvHisSoporteIdUsuarioEmisorNavigations = new HashSet<InvHisSoporte>();
            InvHisSoporteIdUsuarioResuelveNavigations = new HashSet<InvHisSoporte>();
            InvRelUsuarioRols = new HashSet<InvRelUsuarioRol>();
            RelLoginSistemaUsuarios = new HashSet<RelLoginSistemaUsuario>();
        }

        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string NumeroTelefonico { get; set; }
        public string NumeroExtension { get; set; }
        public double? PstCorreo { get; set; }
        public string UsuarioWindows { get; set; }
        public bool EsUsuarioSap { get; set; }
        public bool? EsCorporativo { get; set; }
        public string Password { get; set; }
        public int? IdPuesto { get; set; }
        public int? IdDepartamento { get; set; }
        public int? IdPlanta { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual CatDepartamento IdDepartamentoNavigation { get; set; }
        public virtual CatPlantum IdPlantaNavigation { get; set; }
        public virtual CatPuesto IdPuestoNavigation { get; set; }
        public virtual ICollection<InvHisAccionEquipo> InvHisAccionEquipos { get; set; }
        public virtual ICollection<InvHisGrupoUsuario> InvHisGrupoUsuarios { get; set; }
        public virtual ICollection<InvHisSoporte> InvHisSoporteIdUsuarioEmisorNavigations { get; set; }
        public virtual ICollection<InvHisSoporte> InvHisSoporteIdUsuarioResuelveNavigations { get; set; }
        public virtual ICollection<InvRelUsuarioRol> InvRelUsuarioRols { get; set; }
        public virtual ICollection<RelLoginSistemaUsuario> RelLoginSistemaUsuarios { get; set; }
    }
}

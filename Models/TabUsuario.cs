using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace InventarioTI.Models
{
    public partial class TabUsuario
    {
        public TabUsuario()
        {
            InvHisGrupoUsuarios = new HashSet<InvHisGrupoUsuario>();
            InvHisSoporteIdUsuarioEmisorNavigations = new HashSet<InvHisSoporte>();
            InvHisSoporteIdUsuarioResuelveNavigations = new HashSet<InvHisSoporte>();
            InvRelUsuarioRols = new HashSet<InvRelUsuarioRol>();
            RelLoginSistemaUsuarios = new HashSet<RelLoginSistemaUsuario>();
        }

        [Display(Name ="ID")]
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        [Display(Name ="Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string NumeroTelefonico { get; set; }
        public string NumeroExtension { get; set; }
        public double? PstCorreo { get; set; }
        [Display(Name ="Usuario Windows")]
        public string UsuarioWindows { get; set; }
        public bool EsUsuarioSap { get; set; }
        public bool? EsCorporativo { get; set; }
        public string Password { get; set; }
        public int? IdPuesto { get; set; }
        [Display(Name ="Departamento")]
        public int? IdDepartamento { get; set; }
        [Display(Name ="Planta")]
        public int? IDSitio { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual CatDepartamento IdDepartamentoNavigation { get; set; }
        public virtual CatPlanta IdPlantaNavigation { get; set; }
        public virtual CatPuesto IdPuestoNavigation { get; set; }
        public virtual ICollection<InvHisGrupoUsuario> InvHisGrupoUsuarios { get; set; }
        public virtual ICollection<InvHisSoporte> InvHisSoporteIdUsuarioEmisorNavigations { get; set; }
        public virtual ICollection<InvHisSoporte> InvHisSoporteIdUsuarioResuelveNavigations { get; set; }
        public virtual ICollection<InvRelUsuarioRol> InvRelUsuarioRols { get; set; }
        public virtual ICollection<RelLoginSistemaUsuario> RelLoginSistemaUsuarios { get; set; }
    }
}

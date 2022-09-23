using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

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

        [Key]
        public int Id { get; set; }
        [Display(Name ="Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }
        [Display(Name = "Fecha de Fin")]
        public DateTime? FechaFin { get; set; }
        [Display(Name ="En Dominio")]
        public bool EnDominio { get; set; }
        [Display(Name ="Tipo de Conexión")]
        [Required(ErrorMessage ="Debes seleccionar un tipo de conexión")]
        public string TipoConexion { get; set; }
        [Display(Name = "Dirección IP")]
        [Required(ErrorMessage ="Debes ingresar la dirección IP")]
        public string Ip { get; set; }
        public int IdEquipo { get; set; }
        [Display(Name ="Departamento")]
        [Required(ErrorMessage ="Debes seleccionar un departamento")]
        public int IdDepartamento { get; set; }
        public bool Activo { get; set; }
        [Display(Name ="Ubicación")]
        public int IDSitio { get; set; }
        [NotMapped]
        [Required(ErrorMessage ="Debes seleccionar por lo menos 1 usuario")]
        public int[] SelectedIds { get; set; }
        public virtual InvTabEquipo IdEquipoNavigation { get; set; }
        public virtual ICollection<InvHisAccionEquipo> InvHisAccionEquipos { get; set; }
        public virtual ICollection<InvHisDesarrolloInstalado> InvHisDesarrolloInstalados { get; set; }
        public virtual ICollection<InvHisGrupoUsuario> InvHisGrupoUsuarios { get; set; }
    }
}
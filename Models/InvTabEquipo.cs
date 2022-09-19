using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvTabEquipo
    {
        public InvTabEquipo()
        {
            InvHisAccionEquipos = new HashSet<InvHisAccionEquipo>();
            InvHisAsignacionEquipos = new HashSet<InvHisAsignacionEquipo>();
            InvHisSoportes = new HashSet<InvHisSoporte>();
        }

        public int Id { get; set; }
        [Display(Name ="Nombre Equipo")]
        public string NombreEquipo { get; set; }
        [Display(Name ="Tipo")]
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        [Display(Name = "Ubicación")]
        public string UbicacionEquipo { get; set; }
        public string Modelo { get; set; }
        [Display(Name = "No.Serie")]
        public string NoSerie { get; set; }
        public string DireccionMac { get; set; }
        public string So { get; set; }
        public string DatosAdicionales { get; set; }
        public string Procesador { get; set; }
        public double Hdd { get; set; }
        public double Ram { get; set; }
        public string Estatus { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaInicioGarantia { get; set; }
        public DateTime? FechaFinGarantia { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? UltimaActualizacion { get; set; }
        public bool Activo { get; set; }
        public int? IdUsuarioRegistro { get; set; }

        public virtual ICollection<InvHisAccionEquipo> InvHisAccionEquipos { get; set; }
        public virtual ICollection<InvHisAsignacionEquipo> InvHisAsignacionEquipos { get; set; }
        public virtual ICollection<InvHisSoporte> InvHisSoportes { get; set; }
    }
}

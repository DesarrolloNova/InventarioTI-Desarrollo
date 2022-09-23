using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Key]
        public int Id { get; set; }
        [Display(Name ="Nombre Equipo")]
        public string NombreEquipo { get; set; }
        [Display(Name ="Tipo")]
        [Required(ErrorMessage = "Debes seleccionar un tipo")]
        public string TipoEquipo { get; set; }
        [Required(ErrorMessage = "Debes ingresar la marca del equipo")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Debes ingresar el modelo del equipo")]
        public string Modelo { get; set; }
        [Display(Name = "No.Serie")]
        [Required(ErrorMessage = "Debes ingresar el número de serie del equipo")]
        public string NoSerie { get; set; }
        [Display(Name ="Dirección MAC")]
        [Required(ErrorMessage = "Debes ingresar la dirección MAC del equipo")]
        public string DireccionMac { get; set; }
        [Display(Name ="Sistema Operativo")]
        [Required(ErrorMessage = "Debes seleccionar un sistema operativo")]
        public string So { get; set; }
        [Display(Name = "Datos Adicionales")]
        public string DatosAdicionales { get; set; }
        [Required(ErrorMessage ="Debes ingresar la información del procesador")]
        public string Procesador { get; set; }
        [Display(Name = "Capacidad Disco Duro")]
        [Required(ErrorMessage = "Debes ingresar la capacidad del disco duro")]
        public double Hdd { get; set; }
        [Display(Name = "Capacidad Memoría RAM")]
        [Required(ErrorMessage = "Debes ingresar la capacidad de la memoria RAM")]
        public double Ram { get; set; }
        [Display(Name ="Fecha Compra")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        //[Required(ErrorMessage = "Ingresa la fecha de compra del dispositivo")]
        public DateTime? FechaCompra { get; set; }
        [Display(Name = "Fecha Inicio Garantía")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? FechaInicioGarantia { get; set; }
        [Display(Name = "Fecha Fín Garantía")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? FechaFinGarantia { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        [Display(Name ="Creación")]
        public DateTime FechaCreacion { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        [Display(Name ="Ultima Actualización")]
        public DateTime? UltimaActualizacion { get; set; }
        public bool Activo { get; set; }
        public int? IdUsuarioRegistro { get; set; }
        [Display(Name ="Estatus")]
        [ForeignKey("Id")]
        public int IdEstatus { get; set; }
        [Display(Name ="Ubicación")]
        [ForeignKey("IDSitio")]
        [Required(ErrorMessage ="Debes seleccionar una planta para el equipo")]
        public int IDSitio { get; set; }

        public virtual ICollection<InvHisAccionEquipo> InvHisAccionEquipos { get; set; }
        public virtual ICollection<InvHisAsignacionEquipo> InvHisAsignacionEquipos { get; set; }
        public virtual ICollection<InvHisSoporte> InvHisSoportes { get; set; }
    }
}

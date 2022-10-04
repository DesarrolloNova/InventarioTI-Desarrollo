using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage ="Debes ingresar la fecha de inicio")]
        [Display(Name ="Fecha de inicio")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "Debes ingresar la fecha de fin")]
        [Display(Name = "Fecha de fin")]
        public DateTime FechaFin { get; set; }
        [Display(Name ="Tipo de Proceso")]
        public string TipoProceso { get; set; }
        public int? IdAsignacion { get; set; }
        public int? IdEquipo { get; set; }
        [Display(Name ="Usuario que Registró")]
        public int? IdUsuarioRegistro { get; set; }

        public virtual InvHisAsignacionEquipo IdAsignacionNavigation { get; set; }
        public virtual InvTabEquipo IdEquipoNavigation { get; set; }
        public virtual TabUsuario IdUsuarioRegistroNavigation { get; set; }
        public virtual ICollection<InvHisPlantillaInstalacion> InvHisPlantillaInstalacions { get; set; }
        public virtual ICollection<InvHisPlantillaMantenimiento> InvHisPlantillaMantenimientos { get; set; }
    }
}

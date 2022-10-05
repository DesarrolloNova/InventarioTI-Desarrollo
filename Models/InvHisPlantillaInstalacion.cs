using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InventarioTI.Models
{
    [Table("InvHisPlantillaInstalacion")]
    public partial class InvHisPlantillaInstalacion
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="¿Se instaló antivirus?")]
        public bool AntivirusInstalado { get; set; }
        [Display(Name = "¿Qué antivirus se instaló?")]
        public string Antivirus { get; set; }
        [Display(Name = "¿Se instaló paquetería de office?")]
        public bool PaqueteriaOfficeInstalado { get; set; }
        [Display(Name = "¿Qué versión de office se instaló?")]
        public string PaqueteriaOffice { get; set; }
        [Display(Name = "¿Se encontraron otras aplicaciones?")]
        public bool OtrasAplicaciones { get; set; }
        [Display(Name = "¿Uso de portales?")]
        public bool UsoPortales { get; set; }
        [Display(Name = "¿Se eliminaron aplicaciones?")]
        public bool SeEliminaronAplicaciones { get; set; }
        [Required(ErrorMessage = "Debes ingresar la capacidad de disco duro disponible")]
        [Min(100, ErrorMessage = "La capacidad de disco duro es muy baja, no puedes guardar este dato")]
        [Display(Name = "Disco duro disponible")]
        public double HddDisponible { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
        [ForeignKey("IdAccionEquipo")]
        public int IdAccionEquipo { get; set; }
        [NotMapped]
        public int IdEquipo { get; set; }
        [NotMapped]
        public DateTime initialDate { get; set; }
        [NotMapped]
        public DateTime finalDate { get; set; }
    }
}

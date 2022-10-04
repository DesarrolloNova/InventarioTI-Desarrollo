using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InventarioTI.Models
{
    public partial class InvHisPlantillaMantenimiento
    {
        public int Id { get; set; }
        [Display(Name = "¿Se realizó depuración de programas?")]
        public bool DepuracionProgramas { get; set; }
        [Display(Name = "¿El equipo funciona?")]
        public bool Funciona { get; set; }
        [Display(Name = "¿Se limpiaron archivos temporales?")]
        public bool LimpiezaTemporales { get; set; }
        [Display(Name = "¿Se desfragmento el disco duro?")]
        public bool DesfragmentacionHdd { get; set; }
        [Display(Name = "¿Se realizó el escaneo del antivirus?")]
        public bool EscaneoAntivirus { get; set; }
        [Display(Name = "¿Se ralizó revisión de archivos?")]
        public bool RevisionArchivos { get; set; }
        [Display(Name = "¿Se encontraron softwares sin licencia?")]
        public bool SoftwareSinLicencia { get; set; }
        [Display(Name = "¿Las licencias del equipo están activadas?")]
        public bool LicenciasActivas { get; set; }
        [Display(Name = "¿Los perifericos están en buen estado?")]
        public bool Perifericos { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdAccionEquipo { get; set; }
        [NotMapped]
        public int IdEquipo { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Debes ingresar la fecha de inicio")]
        public DateTime initialDate { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Debes ingresar la fecha de fin")]
        public DateTime finalDate { get; set; }
    }
}

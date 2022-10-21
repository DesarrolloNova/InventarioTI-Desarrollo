using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioTI.Models
{
    [Table("InvHisAsignacionLicencia")]
    public class InvHisAsignacionLicencia
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
        public int IDSitio { get; set; }
        public int ID_Area { get; set; }
    }
}

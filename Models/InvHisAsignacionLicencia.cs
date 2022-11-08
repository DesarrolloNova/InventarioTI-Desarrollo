﻿using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace InventarioTI.Models
{
    [Table("InvHisAsignacionLicencia")]
    public class InvHisAsignacionLicencia
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }
        [Display(Name = "Fecha de Fin")]
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
        [Display(Name = "Sitio")]
        public int IDSitio { get; set; }
        [Display(Name = "Área")]
        public int ID_Area { get; set; }
        [ForeignKey("IdLicencia")]
        public int IdLicencia { get; set; }
        [NotMapped]
        [AllowNull]
        public int[] SelectedIds { get; set; }
    }
}

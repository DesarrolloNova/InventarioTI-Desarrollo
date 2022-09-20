using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace InventarioTI.Models
{
    public partial class CatPlanta
    {
        public CatPlanta()
        {
            TabUsuarios = new HashSet<TabUsuario>();
        }
        [Key]
        public int IDSitio { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Planta { get; set; }
        public string Direccion { get; set; }
        public string Moneda { get; set; }
        public string Idioma { get; set; }
        public string BaseDatos { get; set; }

        public virtual ICollection<TabUsuario> TabUsuarios { get; set; }
    }
}

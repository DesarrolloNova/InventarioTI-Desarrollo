using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class CatPlantum
    {
        public CatPlantum()
        {
            TabUsuarios = new HashSet<TabUsuario>();
        }

        public int Id { get; set; }
        public string Planta { get; set; }
        public string Compania { get; set; }
        public string Direccion { get; set; }
        public string AbreviacionPlanta { get; set; }
        public string AbreviacionCompania { get; set; }

        public virtual ICollection<TabUsuario> TabUsuarios { get; set; }
    }
}

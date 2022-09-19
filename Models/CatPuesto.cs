using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class CatPuesto
    {
        public CatPuesto()
        {
            TabUsuarios = new HashSet<TabUsuario>();
        }

        public int Id { get; set; }
        public string Puesto { get; set; }

        public virtual ICollection<TabUsuario> TabUsuarios { get; set; }
    }
}

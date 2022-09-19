using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class CatDepartamento
    {
        public CatDepartamento()
        {
            TabUsuarios = new HashSet<TabUsuario>();
        }

        public int Id { get; set; }
        public string Departamento { get; set; }
        public string Abreviacion { get; set; }

        public virtual ICollection<TabUsuario> TabUsuarios { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class TabCorreo
    {
        public int Id { get; set; }
        public string Aplicacion { get; set; }
        public string Smtp { get; set; }
        public string NombreEmisor { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public int? Puerto { get; set; }
        public bool? CredencialesDefault { get; set; }
        public bool? Ssl { get; set; }
    }
}

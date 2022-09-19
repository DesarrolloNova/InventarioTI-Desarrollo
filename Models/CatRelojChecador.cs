using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class CatRelojChecador
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Dispositivo { get; set; }
        public string Ip { get; set; }
        public int Puerto { get; set; }
        public int? IdPlanta { get; set; }
    }
}

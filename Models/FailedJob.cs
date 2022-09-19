using System;
using System.Collections.Generic;

#nullable disable

namespace InventarioTI.Models
{
    public partial class FailedJob
    {
        public long Id { get; set; }
        public string Connection { get; set; }
        public string Queue { get; set; }
        public string Payload { get; set; }
        public string Exception { get; set; }
        public DateTime FailedAt { get; set; }
    }
}

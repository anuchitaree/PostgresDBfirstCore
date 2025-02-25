using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class MasterLossByLine
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public string? LossId { get; set; }
    }
}

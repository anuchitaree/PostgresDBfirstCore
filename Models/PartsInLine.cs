using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class PartsInLine
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public string? PartNo { get; set; }
        public double? Ct { get; set; }
        public int? Manpower { get; set; }
    }
}

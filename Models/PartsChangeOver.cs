using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class PartsChangeOver
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public string? PartOg { get; set; }
        public string? PartChange { get; set; }
        public double? TimeDelayMinute { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class LineStation
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public string? StationId { get; set; }
        public string? StationName { get; set; }
        public string? ChildEquIdV2 { get; set; }
        public string? ChildEquNameV2 { get; set; }
    }
}

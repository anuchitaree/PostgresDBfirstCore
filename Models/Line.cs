using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class Line
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineGroupId { get; set; }
        public string? LineId { get; set; }
        public string? LineName { get; set; }
        public string? ShiftDayId { get; set; }
        public string? ShiftNightId { get; set; }
        public string? LineIdV2 { get; set; }
        public string? LineNameV2 { get; set; }
        public double? OaTarget { get; set; }
    }
}

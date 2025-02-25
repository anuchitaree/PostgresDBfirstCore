using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class DailyPlan
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public string? ShiftTeam { get; set; }
        public string? ShiftId { get; set; }
        public DateOnly? Date { get; set; }
        public bool? IsDay { get; set; }
        public string? PartNo { get; set; }
        public int? Qty { get; set; }
        public int? Manpower { get; set; }
        public double? Ct { get; set; }
        public int? Order { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
    }
}

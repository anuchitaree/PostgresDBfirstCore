using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class ShiftSlot
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public string? ShiftId { get; set; }
        public string? WorkShiftId { get; set; }
        public DateOnly? OperationalDate { get; set; }
        public string? PlanScan { get; set; }
        public int? PlanQty { get; set; }
        public int? PlanQtyActual { get; set; }
        public int? DurationTime { get; set; }
        public double? RemainingTime { get; set; }
        public string? Remark { get; set; }
        public bool? IsFull { get; set; }
        public DateTime? Timestamp { get; set; }
        public double? Ct { get; set; }
        public double? OrPercentage { get; set; }
        public int? PlanPerCt { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class ScanBuffer
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public string? RawScan { get; set; }
        public int? CodeScan { get; set; }
        public string? CodeType { get; set; }
        public string? DetailShow { get; set; }
        public int? IsActive { get; set; }
        public DateTime? ActiveTime { get; set; }
        public DateOnly? OperationalDate { get; set; }
        public string? ShiftId { get; set; }
    }
}

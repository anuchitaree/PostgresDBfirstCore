using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class ShiftPatternDetailForoperation
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? ShiftId { get; set; }
        public string? DetailId { get; set; }
        public string? Type { get; set; }
        public string? Color { get; set; }
        public TimeOnly? StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }
        public int? DurationTime { get; set; }
    }
}

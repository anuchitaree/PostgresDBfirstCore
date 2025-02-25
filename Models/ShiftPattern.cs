using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class ShiftPattern
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? ShiftId { get; set; }
        public string? ShiftName { get; set; }
        public string? Status { get; set; }
        public bool? IsDay { get; set; }
    }
}

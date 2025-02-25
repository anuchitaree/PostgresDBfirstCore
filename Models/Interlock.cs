using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class Interlock
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public string? LockType { get; set; }
        public bool? IsLock { get; set; }
    }
}

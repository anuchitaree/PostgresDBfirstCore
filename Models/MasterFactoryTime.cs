using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class MasterFactoryTime
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public TimeOnly? StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }
    }
}

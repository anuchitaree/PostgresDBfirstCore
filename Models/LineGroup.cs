using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class LineGroup
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineGroupId { get; set; }
        public string? LineGroupName { get; set; }
        public string? LineGroupIdV2 { get; set; }
        public string? LineGroupNameV2 { get; set; }
    }
}

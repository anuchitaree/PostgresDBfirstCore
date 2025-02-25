using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class ShiftMasterDetail
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? DetailId { get; set; }
        public string? DetailName { get; set; }
        public string? Type { get; set; }
        public string? Code { get; set; }
    }
}

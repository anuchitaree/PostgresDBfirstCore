using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class Part
    {
        public string Id { get; set; } = null!;
        public string? PartNo { get; set; }
        public string? FactoryId { get; set; }
        public string? Model { get; set; }
        public string? PartName { get; set; }
    }
}

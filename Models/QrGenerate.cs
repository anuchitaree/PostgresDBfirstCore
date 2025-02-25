using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class QrGenerate
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? QrId { get; set; }
        public string? Details { get; set; }
    }
}

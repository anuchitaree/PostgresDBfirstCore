using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class MasterLoss
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LossId { get; set; }
        public string? LossCode { get; set; }
        public string? LossName { get; set; }
    }
}

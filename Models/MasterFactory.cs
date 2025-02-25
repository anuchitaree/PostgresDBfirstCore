using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class MasterFactory
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? FactoryCode { get; set; }
        public double? OaTarget { get; set; }
    }
}

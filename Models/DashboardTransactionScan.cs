using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class DashboardTransactionScan
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? LineId { get; set; }
        public DateTime? DateTime { get; set; }
        public string? TypeScan { get; set; }
        public string? ValueScan { get; set; }
        public string? PartNo { get; set; }
        public int? IsActive { get; set; }
    }
}

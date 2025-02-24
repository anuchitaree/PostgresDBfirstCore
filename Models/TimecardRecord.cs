using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class TimecardRecord
    {
        public string Id { get; set; } = null!;
        public string EmpId { get; set; } = null!;
        public DateTime Date { get; set; }
        public string ChildLineId { get; set; } = null!;
        public string MachineSn { get; set; } = null!;
        public bool Status { get; set; }
    }
}

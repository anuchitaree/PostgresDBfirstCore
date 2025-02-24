using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class LogRecord
    {
        public string Id { get; set; } = null!;
        public DateTime Registdatetime { get; set; }
        public string Result { get; set; } = null!;
        public string Decription { get; set; } = null!;
    }
}

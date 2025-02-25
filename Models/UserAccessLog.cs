using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class UserAccessLog
    {
        public string Id { get; set; } = null!;
        public string? UserId { get; set; }
        public string? Username { get; set; }
        public string? AccessType { get; set; }
        public string? IpAddress { get; set; }
        public bool? Success { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace PostgresDBfirstCore.Models
{
    public partial class Manpower
    {
        public string Id { get; set; } = null!;
        public string? FactoryId { get; set; }
        public string? EmpId { get; set; }
        public string? EmpName { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblGroupAgency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public int? Ord { get; set; }
        public string Level { get; set; }
        public bool? Active { get; set; }
        public int? IdUser { get; set; }
    }
}

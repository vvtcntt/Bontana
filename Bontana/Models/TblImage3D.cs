﻿using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblImage3D
    {
        public int Id { get; set; }
        public int? IdProduct { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public string Images { get; set; }
    }
}

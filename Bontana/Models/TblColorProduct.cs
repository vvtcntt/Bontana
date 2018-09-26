using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblColorProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public bool? Active { get; set; }
        public int? Ord { get; set; }
    }
}

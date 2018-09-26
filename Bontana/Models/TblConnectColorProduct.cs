using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblConnectColorProduct
    {
        public int Id { get; set; }
        public int? IdColor { get; set; }
        public int? IdPro { get; set; }
    }
}

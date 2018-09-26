using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblConnectManuProduct
    {
        public int Id { get; set; }
        public int? IdManu { get; set; }
        public int? IdCate { get; set; }
    }
}

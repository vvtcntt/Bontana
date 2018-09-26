using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblConnectManuToAddress
    {
        public int Id { get; set; }
        public int? IdManu { get; set; }
        public int? IdAdress { get; set; }
    }
}

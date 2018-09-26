using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblRegister
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? IdCate { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? Active { get; set; }
    }
}

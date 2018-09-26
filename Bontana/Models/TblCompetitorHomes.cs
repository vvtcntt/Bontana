using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblCompetitorHomes
    {
        public int Id { get; set; }
        public string CodeProduct { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? Ord { get; set; }
        public bool? Active { get; set; }
        public int? IdUser { get; set; }
    }
}

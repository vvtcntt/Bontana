using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblCompetitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Website { get; set; }
        public int? Ord { get; set; }
        public bool? Active { get; set; }
        public int? IdUser { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}

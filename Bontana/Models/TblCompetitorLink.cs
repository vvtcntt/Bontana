using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblCompetitorLink
    {
        public int Id { get; set; }
        public int? IdHomes { get; set; }
        public int? IdCompetitor { get; set; }
        public string Url { get; set; }
        public int? Ord { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? IdUser { get; set; }
        public bool? Active { get; set; }
    }
}

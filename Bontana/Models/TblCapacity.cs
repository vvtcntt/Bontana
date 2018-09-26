using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblCapacity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string Content { get; set; }
        public int? Ord { get; set; }
        public string Tag { get; set; }
        public string Note { get; set; }
        public bool? Priority { get; set; }
        public bool? Active { get; set; }
        public string Images { get; set; }
        public string Background { get; set; }
        public string ICon { get; set; }
        public string Color { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? IdUser { get; set; }
    }
}

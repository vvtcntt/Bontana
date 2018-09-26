using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblFiles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywork { get; set; }
        public string File { get; set; }
        public string Image { get; set; }
        public int? Ord { get; set; }
        public int? Cate { get; set; }
        public int? Idp { get; set; }
        public int? Idg { get; set; }
        public string Tag { get; set; }
        public bool? Active { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? IdUser { get; set; }
    }
}

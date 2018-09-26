using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblProductSale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CodeOne { get; set; }
        public string CodeTrue { get; set; }
        public string CodeSale { get; set; }
        public string Content { get; set; }
        public string Slogan { get; set; }
        public string TextRun { get; set; }
        public DateTime? StartSale { get; set; }
        public DateTime? StopSale { get; set; }
        public string ImageBanner { get; set; }
        public string ImageSale { get; set; }
        public string ImageThumb { get; set; }
        public bool? Active { get; set; }
        public int? Ord { get; set; }
        public string Tag { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? UserId { get; set; }
    }
}

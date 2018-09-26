using System;
using System.Collections.Generic;

namespace Bontana.Models
{
    public partial class TblProductSyn
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string CodeSyn { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public string Content { get; set; }
        public string Parameter { get; set; }
        public string ImageLinkThumb { get; set; }
        public string ImageLinkDetail { get; set; }
        public double? Price { get; set; }
        public double? PriceSale { get; set; }
        public bool? Vat { get; set; }
        public string Warranty { get; set; }
        public string Address { get; set; }
        public bool? Transport { get; set; }
        public string Access { get; set; }
        public string Sale { get; set; }
        public int? Ord { get; set; }
        public bool? Status { get; set; }
        public bool? Active { get; set; }
        public bool? New { get; set; }
        public bool? ViewHomes { get; set; }
        public int? Visit { get; set; }
        public string Tag { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? IdUser { get; set; }
    }
}

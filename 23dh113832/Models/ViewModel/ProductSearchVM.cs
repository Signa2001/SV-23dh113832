using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23dh113832.Models.ViewModel
{
    public class ProductSearchVM
    {
        public string SearchItem { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string SortOrder { get; set; }
    }
}
using Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models
{
    public class CategoryListViewModel
    {
        public CategoryViewModel Category { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
        public ProductListing OrderBy { get; set; }  
        public int Count { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}

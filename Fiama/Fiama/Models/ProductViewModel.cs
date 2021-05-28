using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models
{
    public class ProductViewModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int SKU { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte StarCount { get; set; }
        public IList<string> Images { get; set; }
        public LabelViewModel Label { get; set; }
        public DiscountViewModel Discount { get; set; } //burda sonunda -s- problemi ?  many to many relations 
        public CategoryViewModel Category { get; set; }
        public IList<ReviewViewModel> Reviews { get; set; }
        public IList<OptionViewModel> Options { get; set; }

    }
}

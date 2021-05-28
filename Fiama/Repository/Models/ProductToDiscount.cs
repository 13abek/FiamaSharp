using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class ProductToDiscount
    {
        public int id { get; set; }
        public int DiscountId { get; set; }
        public int ProductId { get; set; }
        public Discount Discount { get; set; }
        public Product Product { get; set; }
    }
}

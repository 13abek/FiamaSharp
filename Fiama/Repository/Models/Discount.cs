using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
  public  class Discount:BaseEntity
    {
        [Required] 
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public decimal Percentage { get; set; }
        public ICollection<ProductToDiscount> Products { get; set; }
    }
}

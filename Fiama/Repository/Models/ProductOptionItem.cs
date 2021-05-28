using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class ProductOptionItem:BaseEntity
    {
        [Required]
        public int ProductOptionId { get; set; }
        public ProductOption Option { get; set; }
        [Required]
        [MaxLength(150)]
        public string Value { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}

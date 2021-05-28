using Repository.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
  public  class ProductOption:BaseEntity
    {
        [Required]
        public OptionsType Type { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public ICollection<ProductOptionItem> OptionItems { get; set; }
    }
}

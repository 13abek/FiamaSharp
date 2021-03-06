using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public  class Basket:BaseEntity
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class ProductReview: BaseEntity
    {
        [Required]
        public byte star { get; set; }
        [Required]
        [MaxLength(550)]
        public string Content { get; set; }
        [Required]
        [MaxLength(150)]
        public string File { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

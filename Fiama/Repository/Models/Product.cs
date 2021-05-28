using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
   public class Product: BaseEntity

    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public int SKU { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [Column(TypeName ="nText")]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool IsTopProduct { get; set; }
        [Required]
        public bool IsNewArrival { get; set; }
        [Required]
        public bool IsOffSales { get; set; }
        public byte StarCount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int? LabelId { get; set; }
        public Label Label { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<ProductOption> Options { get; set; }
        public ICollection<ProductToDiscount> Discounts { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Basket> Baskets { get; set; }
    }
}

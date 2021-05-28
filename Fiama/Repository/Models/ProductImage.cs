using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class ProductImage:BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

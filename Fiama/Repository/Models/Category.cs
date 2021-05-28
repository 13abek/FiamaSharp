using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
   public class Category:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Product> products { get; set; }
    }
}

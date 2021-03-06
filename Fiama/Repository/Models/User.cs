    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class User:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(150)]
        public string Lastname { get; set; }
        [MaxLength(150)]
        public string Token { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
  public  class Setting:BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
    }
}

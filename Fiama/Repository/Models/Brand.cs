using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Brand:BaseEntity
    {
        //Name de olmalidir

        [Required]
        [MaxLength(100)]
        public string logo { get; set; }
    }
}

using Repository.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
 public  class SliderItem:BaseEntity
    {
        public SliderPosition Position { get; set; }
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(50)]
        public string Uppertitle { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [Required]
        [MaxLength(250)]
        public string Slogan { get; set; }
        [Required]
        [MaxLength(150)]
        public string Image { get; set; }
        [Required]
        [MaxLength(250)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
    }
}

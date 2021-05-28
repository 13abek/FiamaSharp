using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models
{
    public class AddReviewViewModel
    {
        public int ProductId { get; set; }
        //[Required(ErrorMessage = "please select Your Ratings")]
        //[Range(1,5)]
        //public byte star { get; set; }
        [Required]
        [MaxLength(200,ErrorMessage ="Should not exceed a maximum of 250 characters!")]
        public string Content { get; set; }
        [Required(ErrorMessage = "E-mail is required!")]
        public string Email { get; set; }
        public DateTime AddedDate { get; set; }

    }
}

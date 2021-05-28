using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail is required!")]
        [MaxLength(50, ErrorMessage = "Should not exceed a maximum of 50 characters")]
        [EmailAddress(ErrorMessage = "E-mail is incorrect")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        [MaxLength(50, ErrorMessage = "Should not exceed a maximum of 50 characters!")]
        [MinLength(6, ErrorMessage = "must be at least 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

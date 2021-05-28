using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fiama.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="First Name is Required!")]
        [MaxLength(50,ErrorMessage = "Should not exceed a maximum of 50 characters!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required!")]
        [MaxLength(50, ErrorMessage = "Should not exceed a maximum of 50 characters!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "E-mail is required!")]
        [MaxLength(50,ErrorMessage = "Should not exceed a maximum of 50 characters")]
        [EmailAddress(ErrorMessage = "E-mail is incorrect")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required!")]
        [MaxLength(50,ErrorMessage = "Should not exceed a maximum of 50 characters!")]
        [MinLength(6, ErrorMessage = "must be at least 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        [MaxLength(50, ErrorMessage = "Should not exceed a maximum of 50 characters")]
        [MinLength(6,ErrorMessage = "must be at least 6 characters")]
        [Compare("Password",ErrorMessage ="Password and Confirm Password are not the same")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}

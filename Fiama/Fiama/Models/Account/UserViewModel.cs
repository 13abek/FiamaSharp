using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models.Account
{
    public class UserViewModel
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Token { get; set; }
        public IList<ReviewViewModel> Reviews { get; set; }

    }
}

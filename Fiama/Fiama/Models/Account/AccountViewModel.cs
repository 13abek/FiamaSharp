using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models.Account
{
    public class AccountViewModel
    {
        public RegisterViewModel Register { get; set; }
        public LoginViewModel Login { get; set; }
    }
}

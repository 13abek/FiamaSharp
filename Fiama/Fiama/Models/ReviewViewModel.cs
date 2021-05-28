using Fiama.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models
{
    public class ReviewViewModel
    {
        public byte star { get; set; }
        public string Content { get; set; }
        public string File { get; set; }
        public DateTime AddedDate { get; set; }
        public UserViewModel User { get; set; }
    }
}

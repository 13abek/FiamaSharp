using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models
{
    public class CategorySearchViewModel
    {
        public CategorySearchViewModel(){
            Page = 1;
            Limit = 15;
            }
        public int id { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}

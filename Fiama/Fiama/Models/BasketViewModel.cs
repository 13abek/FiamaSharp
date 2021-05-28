﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models
{
    public class BasketViewModel
    {
        public int id { get; set; }     
        public string Token { get; set; }
        public int Count { get; set; }
        public ProductViewModel Product { get; set; }
    }
}

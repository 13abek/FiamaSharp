using Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Models
{
    public class OptionViewModel
    {
        public string Title { get; set; }

        public OptionsType Type { get; set; }

        public string Color { get; set; }

        public List<OptionItemsViewModel> OptionItems { get; set; }

    }
}

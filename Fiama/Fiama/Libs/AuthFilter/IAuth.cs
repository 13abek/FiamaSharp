using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Libs.AuthFilter
{
    public interface IAuth
    {
        User user { get; }
    }
}
